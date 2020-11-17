using DatabaseLibrary.Models;
using System;
using System.Data.Common;

namespace DatabaseLibrary.Data
{
    public class PositionData : CommonData<PositionModel>
    {
        public PositionData(string connectionString) : base(connectionString, "Должности")
        {
        }

        internal override PositionModel MapModel(DbDataReader reader)
        {
            return new PositionModel()
            {
                ID = reader.GetGuid(0),
                Name = reader.GetValue(1).ToString(),
                Description = reader.GetValue(2).ToString(),
            };
        }

        [Obsolete(blockedMethod, true)]
        public override int InsertData(PositionModel model, string procedureName) => base.InsertData(model, procedureName);

        [Obsolete(blockedMethod, true)]
        public override int UpdateData(PositionModel model, string procedureName) => base.UpdateData(model, procedureName);

        [Obsolete(blockedMethod, true)]
        public override int DeleteDataByGuid(Guid ID) => base.DeleteDataByGuid(ID);
    }
}
