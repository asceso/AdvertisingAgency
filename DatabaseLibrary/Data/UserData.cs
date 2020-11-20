using System.Data.Common;
using DatabaseLibrary.Models;

namespace DatabaseLibrary.Data
{
    public class UserData : CommonData<UserModel>
    {
        private readonly PositionData Positions;
        private readonly RoleData Roles;

        public UserData(string connectionString) : base(connectionString, "Сотрудники")
        {
            Positions = new PositionData(connectionString);
            Roles = new RoleData(connectionString);
        }

        public UserData() : base(ConnectionString, "Сотрудники")
        {
            Positions = new PositionData(ConnectionString);
            Roles = new RoleData(ConnectionString);
        }

        internal override UserModel MapModel(DbDataReader reader)
        {
            return new UserModel()
            {
                ID = reader.GetGuid(0),
                FirstName = reader.GetValue(1).ToString(),
                MiddleName = reader.GetValue(2).ToString(),
                LastName = reader.GetValue(3).ToString(),
                Position = Positions.GetDataByGuid(reader.GetGuid(4)),
                ContactNumber = reader.GetValue(5).ToString(),
                Login = reader.GetValue(6).ToString(),
                Password = reader.GetValue(7).ToString(),
                Role = Roles.GetDataByGuid(reader.GetGuid(8))
            };
        }
    }
}
