﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client.Forms;
using DatabaseLibrary.Data;
using DatabaseLibrary.Models;
using Infrastructure.Enums;
using Infrastructure.Models;

namespace Client.UserControls
{
    public partial class UserManageUserControl : UserControl, IClosableUI
    {
        private readonly Dictionary<string, bool> modelHasValue;

        private enum ModelProps { FirstName, MiddleName, LastName, Position }
        private readonly MainForm parentForm;

        private readonly UserModel user;
        private List<PositionModel> positions;

        public string ConnectionString { get; set; }

        public UserManageUserControl(UserModel user, MainForm parentForm, string connectionString)
        {
            InitializeComponent();
            ConnectionString = connectionString;
            this.user = user;
            this.parentForm = parentForm;
            Size = parentForm.CurrentControlSize;
            closeView.Dock = (DockStyle)parentForm.Settings.CloseViewButtonPosition;
            AcceptChangesButton.Enabled = false;

            if (!user.ID.Equals(Guid.Empty))
            {
                Button deleteButton = new Button()
                {
                    Name = "deleteButton",
                    Dock = DockStyle.Top,
                    Text = "Удалить пользователя",
                    Height = elemPanel.Controls[ConstValues.Zero].Height,
                    Cursor = Cursors.Hand
                };
                deleteButton.Click += DeleteButtonClick;
                List<Control> newControlls = new List<Control>
                {
                    deleteButton
                };
                foreach (Control control in elemPanel.Controls)
                {
                    newControlls.Add(control);
                }

                elemPanel.Controls.Clear();
                elemPanel.Controls.AddRange(newControlls.ToArray());
                elemPanel.Size = new Size(elemPanel.Width, elemPanel.Height + deleteButton.Height);
            }

            modelHasValue = new Dictionary<string, bool>();
            foreach (string item in Enum.GetNames(typeof(ModelProps)))
            {
                modelHasValue.Add(item, false);
            }

            fNameTextBox.TextChanged += (s, e)
                => modelHasValue.DictionaryWithButtonEnableManagement(fNameTextBox, nameof(ModelProps.FirstName), AcceptChangesButton);
            mNameTextBox.TextChanged += (s, e)
                => modelHasValue.DictionaryWithButtonEnableManagement(mNameTextBox, nameof(ModelProps.MiddleName), AcceptChangesButton);
            lNameTextBox.TextChanged += (s, e)
                => modelHasValue.DictionaryWithButtonEnableManagement(lNameTextBox, nameof(ModelProps.LastName), AcceptChangesButton);
            positionsComboBox.SelectedIndexChanged += (s, e)
                => modelHasValue.DictionaryWithButtonEnableManagement(positionsComboBox, nameof(ModelProps.Position), AcceptChangesButton);
        }

        private async void DeleteButtonClick(object sender, EventArgs e)
        {
            using (UserData data = new UserData(ConnectionString))
            {
                await data.DeleteDataByGuidAsync(user.ID);
            }

            parentForm.UpdateUsersList();
            Dispose();
        }

        private void UserManageUserControlLoad(object sender, EventArgs e)
        {
            using (PositionData data = new PositionData(ConnectionString))
            {
                positions = data.GetDataCollection().Where(p => !p.Name.Equals("Директор")).ToList();
            }

            positionsComboBox.Items.Clear();
            foreach (PositionModel position in positions)
            {
                positionsComboBox.Items.Add(position.Name);
            }

            fNameTextBox.Text = user.FirstName;
            mNameTextBox.Text = user.MiddleName;
            lNameTextBox.Text = user.LastName;
            contactNumberTextBox.Text = user.ContactNumber;

            if (!user.ID.Equals(Guid.Empty))
            {
                positionsComboBox.SelectedItem = positions.FirstOrDefault(p => p.ID.Equals(user.Position.ID)).Name;
            }
        }

        private async void AcceptChangesButtonClick(object sender, EventArgs e)
        {
            if (!user.ID.Equals(Guid.Empty))
            {
                await UpdateMethod();
            }
            else
            {
                await InsertMethod();
            }

            return;
        }

        private async Task UpdateMethod()
        {
            using (UserData data = new UserData(ConnectionString))
            {
                UserModel updated = user;
                updated.FirstName = fNameTextBox.Text;
                updated.MiddleName = mNameTextBox.Text;
                updated.LastName = lNameTextBox.Text;
                updated.Position = positions.FirstOrDefault(p => p.Name.Equals(positionsComboBox.SelectedItem));
                updated.ContactNumber = contactNumberTextBox.Text;
                await data.UpdateDataAsync(updated, nameof(SQLEnums.StoredProcedureNames.СотрудникиИзменить));
            }
            parentForm.UpdateUsersList(parentForm.UsersListSelectedIndex);
            Dispose();
        }

        private async Task InsertMethod()
        {
            using (UserData data = new UserData(ConnectionString))
            {
                UserModel user = new UserModel()
                {
                    ID = Guid.NewGuid(),
                    FirstName = fNameTextBox.Text,
                    MiddleName = mNameTextBox.Text,
                    LastName = lNameTextBox.Text,
                    Position = positions.FirstOrDefault(p => p.Name.Equals(positionsComboBox.SelectedItem)),
                    ContactNumber = contactNumberTextBox.Text
                };
                user.Role = GetRoleByPosition(user.Position);
                await data.InsertDataAsync(user, nameof(SQLEnums.StoredProcedureNames.СотрудникиДобавить));
            }
            parentForm.UpdateUsersList(parentForm.UsersListSelectedIndex);
            Dispose();
        }

        private RoleModel GetRoleByPosition(PositionModel position)
        {
            using RoleData roleData = new RoleData(ConnectionString);
            List<RoleModel> roles = roleData.GetDataCollection();

            foreach (KeyValuePair<Guid, List<Guid>> pair in parentForm.Settings.RolePositionsDictionary)
            {
                Guid finded = pair.Value.FirstOrDefault(p => p.Equals(position.ID));
                if (finded != null)
                {
                    return roles.FirstOrDefault(r => r.ID.Equals(pair.Key));
                }
            }
            return roles.FirstOrDefault(r => r.Name.Equals("nullRole"));
        }

        public void CloseViewClick(object sender, EventArgs e)
        {
            parentForm.UpdateUsersList(parentForm.UsersListSelectedIndex);
            Dispose();
        }
    }
}
