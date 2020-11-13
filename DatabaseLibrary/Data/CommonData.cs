using Infrastructure.Enums;
using System;
using System.Collections.Generic;
using System.Data.Common;
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

        #region Sync methods

        #region typed methods

        private List<DataType> GetCollectionFromReader(OleDbDataReader reader)
        {
            List<DataType> result = new List<DataType>();
            while (reader.Read())
                result.Add(MapModel(reader));
            return result;
        }

        public List<DataType> GetDataCollection()
        {
            connection.Open();
            OleDbCommand command = connection.CreateCommand();
            command.CommandText = CreateSqlQuery(SQLEnums.QueryTypes.SELECT, tableName);
            var result = GetCollectionFromReader(command.ExecuteReader());
            connection.Close();
            return result;
        }

        public DataType GetDataByGuid(Guid ID)
        {
            connection.Open();
            OleDbCommand command = connection.CreateCommand();
            command.CommandText = CreateSqlQuery(SQLEnums.QueryTypes.SELECT_WHERE, tableName);
            command.Parameters.AddWithValue("@ID", ID);
            OleDbDataReader reader = command.ExecuteReader();
            reader.Read();
            var result = MapModel(reader);
            connection.Close();
            return result;
        }

        #endregion

        #region Virtual methods

        internal virtual DataType MapModel(OleDbDataReader reader)
        { return new DataType(); }

        public virtual int DeleteDataByGuid(Guid ID)
        {
            connection.Open();
            OleDbCommand command = connection.CreateCommand();
            command.CommandText = CreateSqlQuery(SQLEnums.QueryTypes.DELETE, tableName);
            command.Parameters.AddWithValue("@ID", ID);
            var result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        public virtual int InsertData(DataType model, string procedureName)
        {
            connection.Open();
            var parameters = model.GetType().GetProperties()
                .Where(p => p.GetCustomAttributesData().Any(a => a.AttributeType.Equals(typeof(DataProperty))))
                .OrderBy(o => o.CustomAttributes?
                .FirstOrDefault(a => a.AttributeType.Equals(typeof(DataProperty)))
                .ConstructorArguments?[(int)CustomAttribsIndexes.Insert].Value)
                .ToDictionary(m => m.Name, m => m.GetValue(model));

            OleDbCommand command = CreateStoreProcedureCommand(procedureName, parameters);
            var result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        public virtual int UpdateData(DataType model, string procedureName)
        {
            connection.Open();
            var parameters = model.GetType().GetProperties()
                .Where(p => p.GetCustomAttributesData().Any(a => a.AttributeType.Equals(typeof(DataProperty))))
                .OrderBy(o => o.CustomAttributes?
                .FirstOrDefault(a => a.AttributeType.Equals(typeof(DataProperty)))
                .ConstructorArguments?[(int)CustomAttribsIndexes.Update].Value)
                .ToDictionary(m => m.Name, m => m.GetValue(model));

            OleDbCommand command = CreateStoreProcedureCommand(procedureName, parameters);
            var result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }

        #endregion

        #endregion Sync methods

        #region Async methods

        #region typed methods

        private async Task<List<DataType>> GetCollectionFromReaderAsync(DbDataReader reader)
        {
            List<DataType> result = new List<DataType>();
            while (await reader.ReadAsync())
                result.Add(MapModelAsync(reader));
            return result;
        }

        public async Task<List<DataType>> GetDataCollectionAsync()
        {
            await connection.OpenAsync();
            OleDbCommand command = connection.CreateCommand();
            command.CommandText = CreateSqlQuery(SQLEnums.QueryTypes.SELECT, tableName);
            DbDataReader asyncReader = await command.ExecuteReaderAsync();
            var result = await GetCollectionFromReaderAsync(asyncReader);
            asyncReader.Close();
            connection.Close();
            return result;
        }

        public async Task<DataType> GetDataByGuidAsync(Guid ID)
        {
            await connection.OpenAsync();
            OleDbCommand command = connection.CreateCommand();
            command.CommandText = CreateSqlQuery(SQLEnums.QueryTypes.SELECT_WHERE, tableName);
            command.Parameters.AddWithValue("@ID", ID);
            DbDataReader asyncReader = await command.ExecuteReaderAsync();
            await asyncReader.ReadAsync();
            var result = MapModelAsync(asyncReader);
            asyncReader.Close();
            connection.Close();
            return result;
        }

        #endregion

        #region Virtual methods

        internal virtual DataType MapModelAsync(DbDataReader reader)
        { return new DataType(); }

        public async virtual Task<int> DeleteDataByGuidAsync(Guid ID)
        {
            await connection.OpenAsync();
            OleDbCommand command = connection.CreateCommand();
            command.CommandText = CreateSqlQuery(SQLEnums.QueryTypes.DELETE, tableName);
            command.Parameters.AddWithValue("@ID", ID);
            var result = await command.ExecuteNonQueryAsync();
            connection.Close();
            return result;
        }

        public async virtual Task<int> InsertDataAsync(DataType model, string procedureName)
        {
            await connection.OpenAsync();
            var parameters = model.GetType().GetProperties()
                .Where(p => p.GetCustomAttributesData().Any(a => a.AttributeType.Equals(typeof(DataProperty))))
                .OrderBy(o => o.CustomAttributes?
                .FirstOrDefault(a => a.AttributeType.Equals(typeof(DataProperty)))
                .ConstructorArguments?[(int)CustomAttribsIndexes.Insert].Value)
                .ToDictionary(m => m.Name, m => m.GetValue(model));

            OleDbCommand command = CreateStoreProcedureCommand(procedureName, parameters);
            var result = await command.ExecuteNonQueryAsync();
            connection.Close();
            return result;
        }

        public async virtual Task<int> UpdateDataAsync(DataType model, string procedureName)
        {
            await connection.OpenAsync();
            var parameters = model.GetType().GetProperties()
                .Where(p => p.GetCustomAttributesData().Any(a => a.AttributeType.Equals(typeof(DataProperty))))
                .OrderBy(o => o.CustomAttributes?
                .FirstOrDefault(a => a.AttributeType.Equals(typeof(DataProperty)))
                .ConstructorArguments?[(int)CustomAttribsIndexes.Update].Value)
                .ToDictionary(m => m.Name, m => m.GetValue(model));

            OleDbCommand command = CreateStoreProcedureCommand(procedureName, parameters);
            var result = await command.ExecuteNonQueryAsync();
            connection.Close();
            return result;
        }

        #endregion

        #endregion Async methods
    }
}
