using DatabaseLibrary.Models;
using System.Data.OleDb;
using System.Linq.Expressions;

namespace DatabaseLibrary.Data
{
    public class AddditionalClientInfoData : CommonData<AddditionalClientInfoModel>
    {
        public AddditionalClientInfoData(string connectionString) : base(connectionString, "Дополнительная информация клиентов")
        {
        }

        internal override AddditionalClientInfoModel MapModel(OleDbDataReader reader)
        {
            return new AddditionalClientInfoModel()
            {
                ID = reader.GetGuid(0),
                Address = reader.GetString(1),
                AdditionalContactNumber = reader.GetString(2),
                Preferences = reader.GetString(3)
            };
        }
    }
}
