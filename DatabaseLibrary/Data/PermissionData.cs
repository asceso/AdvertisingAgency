using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.OleDb;
using System.Threading.Tasks;
using DatabaseLibrary.Models;
using Infrastructure.Enums;

namespace DatabaseLibrary.Data
{
    public class PermissionData : CommonData<PermissionModel>
    {
        public PermissionData(string connectionString) : base(connectionString, "Разрешения")
        { }
        public PermissionData() : base(ConnectionString, "Разрешения")
        { }

        internal override PermissionModel MapModel(DbDataReader reader)
        {
            return new PermissionModel()
            {
                ID = reader.GetGuid(0),
                Name = reader.GetValue(1).ToString(),
                Description = reader.GetValue(2).ToString()
            };
        }

        public List<PermissionModel> GetPermissionListByRoleGuid(Guid RoleID)
        {
            connection.Open();
            OleDbCommand command = CreateStoreProcedureCommand(
                nameof(SQLEnums.StoredProcedureNames.СписокРазрешенийДляРоли),
                new Dictionary<string, object>() { { "@ID", RoleID } });
            var result = GetCollectionFromReader(command.ExecuteReader());
            connection.Close();
            return result;
        }

        public async Task<List<PermissionModel>> GetPermissionListByRoleGuidAsync(Guid RoleID)
        {
            await connection.OpenAsync();
            OleDbCommand command = CreateStoreProcedureCommand(
                nameof(SQLEnums.StoredProcedureNames.СписокРазрешенийДляРоли),
                new Dictionary<string, object>() { { "@ID", RoleID } });
            DbDataReader asyncReader = await command.ExecuteReaderAsync();
            var result = await GetCollectionFromReaderAsync(asyncReader);
            connection.Close();
            return result;
        }
    }
}
