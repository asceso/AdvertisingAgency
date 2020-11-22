using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.OleDb;
using DatabaseLibrary.Models;
using Infrastructure.Enums;

namespace DatabaseLibrary.Data
{
    public class RequestData : CommonData<RequestModel>
    {
        private readonly RequestTypeData Requests;
        private readonly ServiceData Services;
        private readonly UserData Users;
        private readonly ClientData Clients;

        public RequestData(string connectionString) : base(connectionString, "Заявки")
        {
            Requests = new RequestTypeData(connectionString);
            Services = new ServiceData(connectionString);
            Users = new UserData(connectionString);
            Clients = new ClientData(connectionString);
        }

        public RequestData() : base(ConnectionString, "Заявки")
        {
            Requests = new RequestTypeData(ConnectionString);
            Services = new ServiceData(ConnectionString);
            Users = new UserData(ConnectionString);
            Clients = new ClientData(ConnectionString);
        }

        internal override RequestModel MapModel(DbDataReader reader)
        {
            return new RequestModel()
            {
                ID = reader.GetGuid(0),
                Name = reader.GetValue(1).ToString(),
                Number = reader.GetValue(2).ToString(),
                RequestType = Requests.GetDataByGuid(reader.GetGuid(3)),
                Address = reader.GetValue(4).ToString(),
                Service = Services.GetDataByGuid(reader.GetGuid(5)),
                User = Users.GetDataByGuid(reader.GetGuid(6)),
                TargetUser = Users.GetDataByGuid(reader.GetGuid(7)),
                Client = reader.GetValue(8).Equals(DBNull.Value) ? null : Clients.GetDataByGuid(reader.GetGuid(8)),
                Status = reader.GetInt16(9)
            };
        }

        public int UpdateRequestStatus(Guid requestGuid, int status)
        {
            connection.Open();
            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                {"@Status", status },
                {"@ID", requestGuid },
            };
            OleDbCommand command = CreateStoreProcedureCommand(nameof(SQLEnums.StoredProcedureNames.ОбновитьСтатусЗаявки), parameters);
            int result = command.ExecuteNonQuery();
            connection.Close();
            return result;
        }
    }
}
