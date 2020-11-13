using Client.Forms;
using DatabaseLibrary.Data;
using DatabaseLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Infrastructure.Enums;


namespace Client.UserControls
{
    public partial class UserManageUserControl : UserControl
    {
        private string connectionString;
        private MainForm parentForm;

        private UserModel user;
        private List<PositionModel> positions;

        public UserManageUserControl(UserModel user, string connectionString,MainForm parentForm)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            this.user = user;
            this.parentForm = parentForm;
        }

        private void UserManageUserControl_Load(object sender, EventArgs e)
        {
            using (PositionData data = new PositionData(connectionString))
                positions = data.GetDataCollection().Result;

            comboBox1.Items.Clear();
            foreach (PositionModel position in positions)
                comboBox1.Items.Add(position.Name);

            textEdit1.TextBoxValue = user.FirstName;
            textEdit2.TextBoxValue = user.MiddleName;
            textEdit3.TextBoxValue = user.LastName;

            comboBox1.SelectedItem = positions.FirstOrDefault(p=>p.ID.Equals(user.Position.ID)).Name; 
        }

        private void AcceptChangesButtonClick(object sender, EventArgs e)
        {
            using (UserData data = new UserData(connectionString))
            {
                UserModel updated = user;
                updated.FirstName = textEdit1.TextBoxValue;
                updated.MiddleName = textEdit2.TextBoxValue;
                updated.LastName = textEdit3.TextBoxValue;
                updated.Position = positions.FirstOrDefault(p => p.Name.Equals(comboBox1.SelectedItem));
                data.UpdateData(updated, nameof(SQLEnums.StoredProcedureNames.СотрудникиИзменить));
            }
            parentForm.UpdateUsersList(parentForm.UsersListSelectedIndex);
            Dispose();
        }
    }
}
