using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Enums;

namespace DatabaseLibrary.Data
{
    public class CommonData<DataType> : SQLExecuter where DataType : class, new()
    {
        internal const string blockedMethod = "Данный метод заблокирован";
        private enum CustomAttribsIndexes { Insert, Update }

        public string TableName { get; set; }
        public static string ConnectionString { get; set; }

        #region ctor

        public CommonData(string connectionString, string tableName) : base(connectionString)
        {
            ConnectionString = connectionString;
            TableName = tableName;
        }

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
            command.CommandText = CreateSqlQuery(SQLEnums.QueryTypes.SELECT, TableName);
            var result = GetCollectionFromReader(command.ExecuteReader());
            connection.Close();
            return result;
        }

        public DataType GetDataByGuid(Guid ID)
        {
            connection.Open();
            OleDbCommand command = connection.CreateCommand();
            command.CommandText = CreateSqlQuery(SQLEnums.QueryTypes.SELECT_WHERE, TableName);
            command.Parameters.AddWithValue("@ID", ID);
            OleDbDataReader reader = command.ExecuteReader();
            reader.Read();
            var result = MapModel(reader);
            connection.Close();
            return result;
        }

        #endregion

        #region Virtual methods

        internal virtual DataType MapModel(DbDataReader reader) => new DataType();

        public virtual int DeleteDataByGuid(Guid ID)
        {
            connection.Open();
            OleDbCommand command = connection.CreateCommand();
            command.CommandText = CreateSqlQuery(SQLEnums.QueryTypes.DELETE, TableName);
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

        public virtual int InsertDataWithSqlGeneratedQuery(DataType model)
        {
            connection.Open();
            var parameters = model.GetType().GetProperties()
                .Where(p => p.GetCustomAttributesData().Any(a => a.AttributeType.Equals(typeof(DataProperty))))
                .OrderBy(o => o.CustomAttributes?
                .FirstOrDefault(a => a.AttributeType.Equals(typeof(DataProperty)))
                .ConstructorArguments?[(int)CustomAttribsIndexes.Insert].Value)
                .ToDictionary(m => m.Name, m => m.GetValue(model));

            OleDbCommand command = CreateSqlCommandWithParameters(parameters);

            StringBuilder SQLQuery = new StringBuilder();
            SQLQuery.Append($"INSERT INTO [{TableName}] VALUES (");
            foreach (OleDbParameter item in command.Parameters)
            {
                SQLQuery.Append($"{item.ParameterName}, ");
            }
            string query = SQLQuery.ToString().Remove(SQLQuery.ToString().LastIndexOf(','));
            query += ");";

            command.CommandText = query;
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

        public virtual int UpdateDataWithSqlGeneratedQuery(DataType model)
        {
            connection.Open();
            var parameters = model.GetType().GetProperties()
                .Where(p => p.GetCustomAttributesData().Any(a => a.AttributeType.Equals(typeof(DataProperty))))
                .OrderBy(o => o.CustomAttributes?
                .FirstOrDefault(a => a.AttributeType.Equals(typeof(DataProperty)))
                .ConstructorArguments?[(int)CustomAttribsIndexes.Update].Value)
                .ToDictionary(m => m.Name, m => m.GetValue(model));

            OleDbCommand command = CreateSqlCommandWithParameters(parameters);

            var headers = model.GetType().GetProperties()
                                .Where(p => p.GetCustomAttributesData().Any(a => a.AttributeType.Equals(typeof(DataProperty))))
                                .Where(p => !p.PropertyType.Equals(typeof(Guid)));

            var props = headers
                .Select(p => p.CustomAttributes
                .FirstOrDefault(c => c.AttributeType.Equals(typeof(DescriptionAttribute)))).ToList();

            StringBuilder SQLQuery = new StringBuilder();
            SQLQuery.Append($"UPDATE [{TableName}] SET ");
            int propCounter = 0;
            foreach (OleDbParameter item in command.Parameters)
            {
                if (item.ParameterName.Equals("@ID"))
                    continue;
                SQLQuery.Append($"[{TableName}].[{props[propCounter++].ConstructorArguments[0].Value}] = {item.ParameterName}, ");
            }
            string query = SQLQuery.ToString().Remove(SQLQuery.ToString().LastIndexOf(','));
            query += $" WHERE [{TableName}].[Код] = @ID;";

            command.CommandText = query;
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
                result.Add(MapModel(reader));
            return result;
        }

        public async Task<List<DataType>> GetDataCollectionAsync()
        {
            await connection.OpenAsync();
            OleDbCommand command = connection.CreateCommand();
            command.CommandText = CreateSqlQuery(SQLEnums.QueryTypes.SELECT, TableName);
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
            command.CommandText = CreateSqlQuery(SQLEnums.QueryTypes.SELECT_WHERE, TableName);
            command.Parameters.AddWithValue("@ID", ID);
            DbDataReader asyncReader = await command.ExecuteReaderAsync();
            await asyncReader.ReadAsync();
            var result = MapModel(asyncReader);
            asyncReader.Close();
            connection.Close();
            return result;
        }

        #endregion

        #region Virtual methods

        public virtual async Task<int> DeleteDataByGuidAsync(Guid ID)
        {
            await connection.OpenAsync();
            OleDbCommand command = connection.CreateCommand();
            command.CommandText = CreateSqlQuery(SQLEnums.QueryTypes.DELETE, TableName);
            command.Parameters.AddWithValue("@ID", ID);
            var result = await command.ExecuteNonQueryAsync();
            connection.Close();
            return result;
        }

        public virtual async Task<int> InsertDataAsync(DataType model, string procedureName)
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

        public virtual async Task<int> UpdateDataAsync(DataType model, string procedureName)
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
