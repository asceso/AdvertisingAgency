using DatabaseLibrary.Models;
using System.Data.OleDb;

namespace DatabaseLibrary.Data
{
    public class RequestData : CommonData<RequestModel>
    {
        private readonly ServiceData Services;
        private readonly UserData Users;
        private readonly ClientData Clients;

        public RequestData(string connectionString) : base(connectionString, "Заявки")
        {
            Services = new ServiceData(connectionString);
            Users = new UserData(connectionString);
            Clients = new ClientData(connectionString);
        }

        internal override RequestModel MapModel(OleDbDataReader reader)
        {
            return new RequestModel()
            {
                ID = reader.GetGuid(0),
                Name = reader.GetString(1),
                Number = reader.GetString(2),
                Address = reader.GetString(3),
                Service = Services.GetDataByGuid(reader.GetGuid(4)).Result,
                User = Users.GetDataByGuid(reader.GetGuid(5)).Result,
                Client = Clients.GetDataByGuid(reader.GetGuid(6)).Result,
                Status = reader.GetBoolean(7)
            };
        }
    }
}
