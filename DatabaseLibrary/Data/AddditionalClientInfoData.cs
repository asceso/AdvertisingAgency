using DatabaseLibrary.Models;
using System.Data.Common;

namespace DatabaseLibrary.Data
{
    public class AddditionalClientInfoData : CommonData<AddditionalClientInfoModel>
    {
        public AddditionalClientInfoData(string connectionString) : base(connectionString, "Дополнительная информация клиентов")
        {
        }

        internal override AddditionalClientInfoModel MapModel(DbDataReader reader)
        {
            return new AddditionalClientInfoModel()
            {
                ID = reader.GetGuid(0),
                Address = reader.GetValue(1).ToString(),
                AdditionalContactNumber = reader.GetValue(2).ToString(),
                Preferences = reader.GetValue(3).ToString()
            };
        }
    }
}
