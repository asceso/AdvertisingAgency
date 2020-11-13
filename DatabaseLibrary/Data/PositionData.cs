using DatabaseLibrary.Models;
using System;
using System.Data.OleDb;

namespace DatabaseLibrary.Data
{
    public class PositionData : CommonData<PositionModel>
    {
        public PositionData(string connectionString) : base(connectionString, "Должности")
        {
        }

        internal override PositionModel MapModel(OleDbDataReader reader)
        {
            return new PositionModel()
            {
                ID = reader.GetGuid(0),
                Name = reader.GetString(1),
                Description = reader.GetString(2),
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
