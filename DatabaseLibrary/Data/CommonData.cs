using Infrastructure.Enums;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseLibrary.Data
{
    public class CommonData<DataType> : SQLExecuter where DataType : class, new()
    {
        private enum CustomAttribsIndexes { Insert, Update }

        #region ctor

        private string tableName = string.Empty;
        internal const string blockedMethod = "Данный метод заблокирован";

        public CommonData(string connectionString, string tableName) : base(connectionString)
        { this.tableName = tableName; }

        #endregion

        #region typed methods

        private List<DataType> GetCollectionFromReader(OleDbDataReader reader)
        {
            List<DataType> result = new List<DataType>();
            while (reader.Read())
                result.Add(MapModel(reader));
            return result;
        }

        public async Task<List<DataType>> GetDataCollection()
        {
            OleDbCommand command = connection.CreateCommand();
            command.CommandText = CreateSqlQuery(SQLEnums.QueryTypes.SELECT, tableName);
            return GetCollectionFromReader(command.ExecuteReader());
        }

        public async Task<DataType> GetDataByGuid(Guid ID)
        {
            OleDbCommand command = connection.CreateCommand();
            command.CommandText = CreateSqlQuery(SQLEnums.QueryTypes.SELECT_WHERE, tableName);
            command.Parameters.AddWithValue("@ID", ID);
            OleDbDataReader reader = command.ExecuteReader();
            reader.Read();
            return MapModel(reader);
        }

        #endregion

        #region Virtual methods

        internal virtual DataType MapModel(OleDbDataReader reader)
        { return new DataType(); }

        public virtual async Task<int> DeleteDataByGuid(Guid ID)
        {
            OleDbCommand command = connection.CreateCommand();
            command.CommandText = CreateSqlQuery(SQLEnums.QueryTypes.DELETE, tableName);
            command.Parameters.AddWithValue("@ID", ID);
            return command.ExecuteNonQuery();
        }

        public virtual async Task<int> InsertData(DataType model, string procedureName)
        {
            var parameters = model.GetType().GetProperties()
                .Where(p => p.GetCustomAttributesData().Any(a => a.AttributeType.Equals(typeof(DataProperty))))
                .OrderBy(o => o.CustomAttributes?
                .FirstOrDefault(a => a.AttributeType.Equals(typeof(DataProperty)))
                .ConstructorArguments?[(int)CustomAttribsIndexes.Insert].Value)
                .ToDictionary(m => m.Name, m => m.GetValue(model));

            OleDbCommand command = CreateStoreProcedureCommand(procedureName, parameters);
            var result = await command.ExecuteNonQueryAsync();
            Task.Delay(100);
            return result;
        }

        public virtual async Task<int> UpdateData(DataType model, string procedureName)
        {
            var parameters = model.GetType().GetProperties()
                .Where(p => p.GetCustomAttributesData().Any(a => a.AttributeType.Equals(typeof(DataProperty))))
                .OrderBy(o => o.CustomAttributes?
                .FirstOrDefault(a => a.AttributeType.Equals(typeof(DataProperty)))
                .ConstructorArguments?[(int)CustomAttribsIndexes.Update].Value)
                .ToDictionary(m => m.Name, m => m.GetValue(model));

            OleDbCommand command = CreateStoreProcedureCommand(procedureName, parameters);
            var result = await command.ExecuteNonQueryAsync();
            Task.Delay(100);
            return result;
        }

        #endregion
    }
}
