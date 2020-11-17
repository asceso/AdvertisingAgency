using DatabaseLibrary.Models;
using System.Data.Common;

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

        internal override RequestModel MapModel(DbDataReader reader)
        {
            return new RequestModel()
            {
                ID = reader.GetGuid(0),
                Name = reader.GetValue(1).ToString(),
                Number = reader.GetValue(2).ToString(),
                Address = reader.GetValue(3).ToString(),
                Service = Services.GetDataByGuid(reader.GetGuid(4)),
                User = Users.GetDataByGuid(reader.GetGuid(5)),
                Client = Clients.GetDataByGuid(reader.GetGuid(6)),
                Status = reader.GetBoolean(7)
            };
        }
    }
}
