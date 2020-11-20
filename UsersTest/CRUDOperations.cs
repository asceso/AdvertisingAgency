using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DatabaseLibrary.Data;
using DatabaseLibrary.Models;
using Infrastructure.Enums;
using Infrastructure.Methods;
using Infrastructure.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UsersTest
{
    [TestClass]
    public class CRUDOperations
    {
        private readonly SettingsModel settings;

        public CRUDOperations() => settings = SettingsMethods.ReadConfig(Environment.CurrentDirectory + "\\AppSettings.json");

        [TestMethod("Base CRUD operation sync methods")]
        public void CheckCRUD()
        {
            using UserData data = new UserData(settings.ConnectionString);
            List<UserModel> dataCollection = data.GetDataCollection();

            Guid tempGuid = Guid.NewGuid();
            Guid positionGuid = Guid.NewGuid();

            PositionModel position;

            using (PositionData positionData = new PositionData(settings.ConnectionString))
            {
                positionData.InsertData(
                    new PositionModel()
                    {
                        ID = positionGuid,
                        Name = "Test",
                        Description = "Test"
                    },
                    nameof(SQLEnums.StoredProcedureNames.ДолжностиДобавить));

                position = positionData.GetDataByGuid(positionGuid);
            }

            using RoleData roleData = new RoleData(settings.ConnectionString);
            var dbRoles = roleData.GetDataCollection();
            RoleModel temp = roleData.GetDataByGuid(dbRoles.Find(r => r.Name.Equals("nullRole")).ID);

            data.InsertData(
                new UserModel()
                {
                    ID = tempGuid,
                    FirstName = "Test",
                    MiddleName = "Test",
                    LastName = "Test",
                    ContactNumber = "88005553535",
                    Position = position,
                    Role = temp
                },
                nameof(SQLEnums.StoredProcedureNames.СотрудникиДобавить));

            var models = data.GetDataCollection();

            UserModel someModel = data.GetDataByGuid(tempGuid);
            data.UpdateData(someModel, nameof(SQLEnums.StoredProcedureNames.СотрудникиИзменить));

            data.DeleteDataByGuid(tempGuid);
            using (PositionData positionData = new PositionData(settings.ConnectionString))
            {
                positionData.DeleteDataByGuid(positionGuid);
            }

            models = data.GetDataCollection();
        }

        [TestMethod("Base CRUD operation async methods")]
        public void CheckCRUDAsync()
        {
            Task.Run(async () =>
            {
                using UserData data = new UserData(settings.ConnectionString);
                List<UserModel> dataCollection = await data.GetDataCollectionAsync();

                Guid tempGuid = Guid.NewGuid();
                Guid positionGuid = Guid.NewGuid();

                PositionModel position;

                using (PositionData positionData = new PositionData(settings.ConnectionString))
                {
                    await positionData.InsertDataAsync(
                        new PositionModel()
                        {
                            ID = positionGuid,
                            Name = "Test",
                            Description = "Test"
                        },
                        nameof(SQLEnums.StoredProcedureNames.ДолжностиДобавить));

                    position = await positionData.GetDataByGuidAsync(positionGuid);
                }

                await data.InsertDataAsync(
                    new UserModel()
                    {
                        ID = tempGuid,
                        FirstName = "Test",
                        MiddleName = "Test",
                        LastName = "Test",
                        ContactNumber = "88005553535",
                        Position = position
                    },
                    nameof(SQLEnums.StoredProcedureNames.СотрудникиДобавить));

                var models = await data.GetDataCollectionAsync();

                UserModel someModel = await data.GetDataByGuidAsync(tempGuid);
                await data.UpdateDataAsync(someModel, nameof(SQLEnums.StoredProcedureNames.СотрудникиИзменить));

                await data.DeleteDataByGuidAsync(tempGuid);

                using (PositionData positionData = new PositionData(settings.ConnectionString))
                    await positionData.DeleteDataByGuidAsync(positionGuid);

                models = data.GetDataCollectionAsync().Result;
            });
        }
    }
}
