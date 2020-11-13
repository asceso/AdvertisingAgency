using Client.UserControls;
using DatabaseLibrary.Data;
using DatabaseLibrary.Models;
using Infrastructure.Enums;
using Infrastructure.Methods;
using Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Client.Forms
{
    public partial class MainForm : Form
    {
        private SettingsModel settings;
        private List<UserModel> UsersCollection;

        public int UsersListSelectedIndex { get => UsersList.SelectedIndex; }

        public MainForm()
        {
            InitializeComponent();
            settings = SettingsMethods.ReadConfig();
            SettingsMethods.CheckDatabaseExist(settings);

            UpdateUsersList();
        }

        #region users

        internal void UpdateUsersList(int selected = -1)
        {
            using (UserData data = new UserData(settings.ConnectionString))
                UsersCollection = data.GetDataCollection().Result;

            UsersList.Items.Clear();
            foreach (var user in UsersCollection)
            {
                UsersList.Items.Add($"{user.GetFullName}, {user.Position.Name}");
            }
            UsersList.SelectedIndex = selected;
        }
        private void UsersListKeyPress(object sender, KeyPressEventArgs e) 
        {
            if (e.KeyChar.Equals((char)Keys.Escape)) 
                UsersList.SelectedIndex = -1;
        }

        #region manage

        private void UsersListMouseDoubleClick(object sender, MouseEventArgs e) => UsersManageButton.PerformClick();
        private void UsersManageButtonClick(object sender, EventArgs e)
        {
            if (!UsersList.SelectedIndex.Equals(-1))
                ChangeUserControl(new UserManageUserControl(UsersCollection[UsersList.SelectedIndex], settings.ConnectionString, this));
        }

        #endregion manage

        #endregion users

        private void ChangeUserControl(UserControl opened)
        {
            CurrentControl.Controls.Clear();
            CurrentControl.Controls.Add(opened);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<UserModel> models;
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
