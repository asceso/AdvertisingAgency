using DatabaseLibrary.Data;
using DatabaseLibrary.Models;
using Infrastructure.Enums;
using Infrastructure.Methods;
using Infrastructure.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UsersTest
{
    [TestClass]
    public class CRUDOperations
    {
        private SettingsModel settings;
        private List<UserModel> models;

        public CRUDOperations()
        {
            settings = SettingsMethods.ReadConfig();
        }

        [TestMethod]
        public void CheckCRUD()
        {
            using (UserData data = new UserData(settings.ConnectionString))
            {
                
                List<UserModel> dataCollection = data.GetDataCollection().Result;
                
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

                    position = positionData.GetDataByGuid(positionGuid).Result;
                }
                
                data.InsertData(
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

                models = data.GetDataCollection().Result;

                UserModel someModel = data.GetDataByGuid(tempGuid).Result;
                data.UpdateData(someModel, nameof(SQLEnums.StoredProcedureNames.СотрудникиИзменить));

                data.DeleteDataByGuid(tempGuid);

                models = data.GetDataCollection().Result;
            }
        }
    }
}
