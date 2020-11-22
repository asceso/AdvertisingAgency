using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using Infrastructure.Enums;

namespace DatabaseLibrary
{
    public class SQLExecuter : IDisposable
    {
        #region ctor

        public OleDbConnection connection;
        public SQLExecuter(string connectionString) => connection = new OleDbConnection(connectionString);
        public void Dispose()
        {
            if (!connection.State.Equals(ConnectionState.Closed))
            {
                connection.Close();
            }

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
        [Obsolete("", true)]
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
            return type switch
            {
                SQLEnums.QueryTypes.SELECT => $"SELECT * FROM [{table}];",
                SQLEnums.QueryTypes.SELECT_WHERE => $"SELECT * FROM [{table}] WHERE [{table}].[Код] = @ID;",
                SQLEnums.QueryTypes.DELETE => $"DELETE * FROM [{table}] WHERE [{table}].[Код] = @ID;",
                _ => string.Empty,
            };
        }

        internal OleDbCommand CreateStoreProcedureCommand(string ProcedureName, Dictionary<string, object> parameters = null)
        {
            OleDbCommand command = connection.CreateCommand();
            command.CommandText = $"[{ProcedureName}]";
            command.CommandType = CommandType.StoredProcedure;
            foreach (KeyValuePair<string, object> parameter in parameters)
            {
                if (parameter.Value is DataModel)
                {
                    if ((parameter.Value as DataModel).IsIgnorable)
                    {
                        continue;
                    }
                }

                command.Parameters.AddWithValue(
                    $"@{parameter.Key}",
                    parameter.Value is DataModel ?
                    (parameter.Value as DataModel).ID : parameter.Value ?? DBNull.Value
                    );
            }
            return command;
        }

        internal OleDbCommand CreateSqlCommandWithParameters(Dictionary<string, object> parameters = null)
        {
            OleDbCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            foreach (KeyValuePair<string, object> parameter in parameters)
            {
                if (parameter.Value is DataModel)
                {
                    if ((parameter.Value as DataModel).IsIgnorable)
                    {
                        continue;
                    }
                }

                command.Parameters.AddWithValue(
                    $"@{parameter.Key}",
                    parameter.Value is DataModel ?
                    (parameter.Value as DataModel).ID : parameter.Value ?? DBNull.Value
                    );
            }
            return command;
        }

        public int ExecuteStoreProcedureWithoutParameters(string ProcedureName)
        {
            connection.Open();
            OleDbCommand command = connection.CreateCommand();
            command.CommandText = $"[{ProcedureName}]";
            command.CommandType = CommandType.StoredProcedure;
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }
    }
}
