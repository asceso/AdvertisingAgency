using System.Data.Common;
using DatabaseLibrary.Models;

namespace DatabaseLibrary.Data
{
    public class ArchiveData : CommonData<ArchiveModel>
    {
        private readonly ClientData Clients;
        public ArchiveData(string connectionString) : base(connectionString, "Архив клиентов")
            => Clients = new ClientData(connectionString);
        public ArchiveData() : base(ConnectionString, "Архив клиентов")
            => Clients = new ClientData(ConnectionString);

        internal override ArchiveModel MapModel(DbDataReader reader)
        {
            return new ArchiveModel()
            {
                ID = reader.GetGuid(0),
                Client = Clients.GetDataByGuid(reader.GetGuid(1)),
                Reason = reader.GetValue(2).ToString()
            };
        }
    }
}
