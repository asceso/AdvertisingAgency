using System;
using System.Data.Common;
using DatabaseLibrary.Models;

namespace DatabaseLibrary.Data
{
    public class ClientData : CommonData<ClientModel>
    {
        private readonly AddditionalClientInfoData AddditionaClientlInfoes;
        public ClientData(string connectionString) : base(connectionString, "Клиенты")
            => AddditionaClientlInfoes = new AddditionalClientInfoData(connectionString);

        public ClientData() : base(ConnectionString, "Клиенты")
            => AddditionaClientlInfoes = new AddditionalClientInfoData(ConnectionString);

        internal override ClientModel MapModel(DbDataReader reader)
        {
            ClientModel model = new ClientModel()
            {
                ID = reader.GetGuid(0),
                FirstName = reader.GetValue(1).ToString(),
                MiddleName = reader.GetValue(2).ToString(),
                LastName = reader.GetValue(3).ToString(),
                ContactNumber = reader.GetValue(4).ToString(),
                OrdersCount = reader.GetInt32(5)
            };
            if (!reader.GetValue(6).Equals(DBNull.Value))
            {
                model.AddtionalInfo = AddditionaClientlInfoes.GetDataByGuid(reader.GetGuid(6));
            }

            return model;
        }
    }
}
