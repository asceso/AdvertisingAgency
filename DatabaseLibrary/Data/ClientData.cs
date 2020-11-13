using DatabaseLibrary.Models;
using System.Data.OleDb;

namespace DatabaseLibrary.Data
{
    public class ClientData : CommonData<ClientModel>
    {
        private readonly AddditionalClientInfoData AddditionaClientlInfoes;
        public ClientData(string connectionString) : base(connectionString, "Клиенты")
        {
            AddditionaClientlInfoes = new AddditionalClientInfoData(connectionString);
        }

        internal override ClientModel MapModel(OleDbDataReader reader)
        {
            return new ClientModel()
            {
                ID = reader.GetGuid(0),
                FirstName = reader.GetString(1),
                MiddleName = reader.GetString(2),
                LastName = reader.GetString(3),
                ContactNumber = reader.GetString(4),
                OrdersCount = reader.GetInt32(5),
                AddtionalInfo = AddditionaClientlInfoes.GetDataByGuid(reader.GetGuid(6))
            };
        }
    }
}
