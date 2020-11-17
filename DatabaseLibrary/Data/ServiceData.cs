using DatabaseLibrary.Models;
using System.Data.Common;

namespace DatabaseLibrary.Data
{
    public class ServiceData : CommonData<ServiceModel>
    {
        public ServiceData(string connectionString) : base(connectionString, "Услуги")
        {
        }
        internal override ServiceModel MapModel(DbDataReader reader)
        {
            return new ServiceModel()
            {
                ID = reader.GetGuid(0),
                Name = reader.GetValue(1).ToString(),
                Description = reader.GetValue(2).ToString(),
                Price = reader.GetDouble(3)
            };
        }
    }
}
