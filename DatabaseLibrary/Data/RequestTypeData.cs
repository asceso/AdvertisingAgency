using DatabaseLibrary.Models;
using System.Data.Common;

namespace DatabaseLibrary.Data
{
    public class RequestTypeData : CommonData<RequestTypeModel>
    {
        public RequestTypeData(string connectionString) : base(connectionString, "Типы заявок")
        {
        }

        internal override RequestTypeModel MapModel(DbDataReader reader)
        {
            return new RequestTypeModel()
            {
                ID = reader.GetGuid(0),
                Name = reader.GetValue(1).ToString(),
                Description = reader.GetValue(2).ToString()
            };
        }
    }
}
