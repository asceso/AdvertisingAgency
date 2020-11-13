using DatabaseLibrary.Models;
using System.Data.OleDb;

namespace DatabaseLibrary.Data
{
    public class ServiceData : CommonData<ServiceModel>
    {
        public ServiceData(string connectionString) : base(connectionString, "Услуги")
        {
        }
        internal override ServiceModel MapModel(OleDbDataReader reader)
        {
            return new ServiceModel()
            {
                ID = reader.GetGuid(0),
                Name = reader.GetString(1),
                Description = reader.GetString(2),
                Price = reader.GetDouble(3)
            };
        }
    }
}
