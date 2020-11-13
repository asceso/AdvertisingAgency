using Infrastructure.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace DatabaseLibrary
{
    public class SQLExecuter : IDisposable
    {
        #region ctor

        public OleDbConnection connection;
        public SQLExecuter(string connectionString)
        {
            connection = new OleDbConnection(connectionString);
            if (!connection.State.Equals(ConnectionState.Open))
                connection.Open();
        }
        public void Dispose()
        {
            if (!connection.State.Equals(ConnectionState.Closed))
                connection.Close();
            GC.Collect();
        }

        #endregion

        #region obsolete
        #region data reader
        [Obsolete("", true)]
        private List<object> GetListFromReader(OleDbDataReader reader)
        {
            List<object> result = new List<object>();
            while (reader.Read())
            {
                List<object> row = new List<object>();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    row.Add(reader.GetValue(i));
                }
                result.Add(row);
            }
            return result;
        }
        #endregion data reader
        #region store procedure
        [Obsolete("",true)]
        public List<object> ExecuteStoreProcedure(string ProcedureName)
        {
            OleDbCommand command = CreateStoreProcedureCommand(ProcedureName);
            return GetListFromReader(command.ExecuteReader());
        }
        [Obsolete("", true)]
        public object ExecuteScalarStoreProcedure(string ProcedureName)
        {
            OleDbCommand command = CreateStoreProcedureCommand(ProcedureName);
            return command.ExecuteScalar();
        }
        #endregion store procedure
        #endregion obsolete

        internal string CreateSqlQuery(SQLEnums.QueryTypes type, string table)
        {
            switch (type)
            {
                case SQLEnums.QueryTypes.SELECT:
                    return $"SELECT * FROM [{table}];";
                case SQLEnums.QueryTypes.SELECT_WHERE:
                    return $"SELECT * FROM [{table}] WHERE [{table}].[Код] = @ID;";
                case SQLEnums.QueryTypes.DELETE:
                    return $"DELETE * FROM [{table}] WHERE [{table}].[Код] = @ID;";
                default:
                    return string.Empty;
            }
        }
        internal OleDbCommand CreateStoreProcedureCommand(string ProcedureName, Dictionary<string, object> parameters = null)
        {
            OleDbCommand command = connection.CreateCommand();
            command.CommandText = $"[{ProcedureName}]";
            command.CommandType = CommandType.StoredProcedure;
            foreach (var parameter in parameters)
                command.Parameters.AddWithValue(
                    $"@{parameter.Key}",
                    parameter.Value is DataModel ? (parameter.Value as DataModel).ID : parameter.Value
                    );
            return command;
        }
    }
}
