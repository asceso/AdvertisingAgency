using DatabaseLibrary.Models;
using System.Data.OleDb;

namespace DatabaseLibrary.Data
{
    public class RequestTypeData : CommonData<RequestTypeModel>
    {
        public RequestTypeData(string connectionString) : base(connectionString, "Типы заявок")
        {
        }

        internal override RequestTypeModel MapModel(OleDbDataReader reader)
        {
            return new RequestTypeModel()
            {
                ID = reader.GetGuid(0),
                Name = reader.GetString(1),
                Description = reader.GetString(2)
            };
        }
    }
}
