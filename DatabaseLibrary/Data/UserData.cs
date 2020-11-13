using DatabaseLibrary.Models;
using System;
using System.Data.OleDb;

namespace DatabaseLibrary.Data
{
    public class UserData : CommonData<UserModel>
    {
        private readonly PositionData Positions;
        public UserData(string connectionString) : base(connectionString, "Сотрудники")
        {
            Positions = new PositionData(connectionString);
        }

        internal override UserModel MapModel(OleDbDataReader reader)
        {
            return new UserModel()
            {
                ID = reader.GetGuid(0),
                FirstName = reader.GetString(1),
                MiddleName = reader.GetString(2),
                LastName = reader.GetString(3),
                Position = Positions.GetDataByGuid(reader.GetGuid(4)).Result,
                ContactNumber = reader.GetString(5),
            };
        }
    }
}
