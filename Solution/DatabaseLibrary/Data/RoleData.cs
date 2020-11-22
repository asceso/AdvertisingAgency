using System;
using System.Data.Common;
using System.Threading.Tasks;
using DatabaseLibrary.Models;

namespace DatabaseLibrary.Data
{
    public class RoleData : CommonData<RoleModel>
    {
        public RoleData(string connectionString) : base(connectionString, "Роли")
        { }

        public RoleData() : base(ConnectionString, "Роли")
        { }

        internal override RoleModel MapModel(DbDataReader reader)
        {
            return new RoleModel()
            {
                ID = reader.GetGuid(0),
                Name = reader.GetValue(1).ToString(),
                Description = reader.GetValue(2).ToString(),
            };
        }

        [Obsolete(blockedMethod, true)]
        public override int InsertData(RoleModel model, string procedureName) => base.InsertData(model, procedureName);

        [Obsolete(blockedMethod, true)]
        public override int UpdateData(RoleModel model, string procedureName) => base.UpdateData(model, procedureName);

        [Obsolete(blockedMethod, true)]
        public override int DeleteDataByGuid(Guid ID) => base.DeleteDataByGuid(ID);

        [Obsolete(blockedMethod, true)]
        public override async Task<int> InsertDataAsync(RoleModel model, string procedureName) => await base.InsertDataAsync(model, procedureName);

        [Obsolete(blockedMethod, true)]
        public override async Task<int> UpdateDataAsync(RoleModel model, string procedureName) => await base.UpdateDataAsync(model, procedureName);

        [Obsolete(blockedMethod, true)]
        public override async Task<int> DeleteDataByGuidAsync(Guid ID) => await base.DeleteDataByGuidAsync(ID);
    }
}
