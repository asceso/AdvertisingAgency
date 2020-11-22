using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.OleDb;
using DatabaseLibrary.Models;
using Infrastructure.Enums;

namespace DatabaseLibrary.Data
{
    public class RolePermissionData : CommonData<RolePermissionModel>
    {
        public RolePermissionData(string connectionString) : base(connectionString, "Разрешения ролей") { }

        public RolePermissionData() : base(ConnectionString, "Разрешения ролей") { }

        internal override RolePermissionModel MapModel(DbDataReader reader)
        {
            return new RolePermissionModel()
            {
                ID = reader.GetGuid(0),
                RoleGuid = reader.GetGuid(1),
                PermissionGuid = reader.GetGuid(2),
            };
        }

        public int DeleteDataByRoleGuidAndPermissionGuid(Guid roleGuid, Guid permissionGuid)
        {
            connection.Open();
            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                {"@RoleGuid", roleGuid },
                {"@PermissionGuid", permissionGuid },
            };
            OleDbCommand command = CreateStoreProcedureCommand(nameof(SQLEnums.StoredProcedureNames.РазрешенияРолейУдалить), parameters);
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }
    }
}
