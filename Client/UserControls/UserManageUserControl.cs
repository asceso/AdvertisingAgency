using Client.Forms;
using DatabaseLibrary.Data;
using DatabaseLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Infrastructure.Enums;
using System.Threading.Tasks;
using System.Drawing;
using Infrastructure.Models;

namespace Client.UserControls
{
    public partial class UserManageUserControl : UserControl
    {
        private Dictionary<string, bool> modelHasValue;
        enum modelProps { FirstName, MiddleName, LastName, Position }

        private string connectionString;
        private MainForm parentForm;

        private UserModel user;
        private List<PositionModel> positions;

        public UserManageUserControl(UserModel user, MainForm parentForm, string connectionString)
        {
            InitializeComponent();
            this.connectionString = connectionString;
            this.user = user;
            this.parentForm = parentForm;
            Size = parentForm.CurrentControlSize;
            AcceptChangesButton.Enabled = false;

            if (!user.ID.Equals(Guid.Empty))
            {
                Button deleteButton = new Button()
                {
                    Name = "deleteButton",
                    Dock = DockStyle.Top,
                    Text = "Удалить пользователя",
                    Height = elemPanel.Controls[ConstValues.ZeroIndex].Height,
                    Cursor = Cursors.Hand
                };
                deleteButton.Click += DeleteButtonClick;
                List<Control> newControlls = new List<Control>();
                newControlls.Add(deleteButton);
                foreach (Control control in elemPanel.Controls)
                    newControlls.Add(control);
                elemPanel.Controls.Clear();
                elemPanel.Controls.AddRange(newControlls.ToArray());
                elemPanel.Size = new Size(elemPanel.Width, elemPanel.Height + deleteButton.Height);
            }

            modelHasValue = new Dictionary<string, bool>();
            foreach (var item in Enum.GetNames(typeof(modelProps)))
                modelHasValue.Add(item, false);

            textBox1.TextChanged += (s, e) 
                => { modelHasValue[nameof(modelProps.FirstName)] = !string.IsNullOrEmpty(textBox1.Text); NotifyChanges(); };
            textBox2.TextChanged += (s, e) 
                => { modelHasValue[nameof(modelProps.MiddleName)] = !string.IsNullOrEmpty(textBox2.Text); NotifyChanges(); };
            textBox3.TextChanged += (s, e) 
                => { modelHasValue[nameof(modelProps.LastName)] = !string.IsNullOrEmpty(textBox3.Text); NotifyChanges(); };
            comboBox1.SelectedIndexChanged += (s, e) 
                => { modelHasValue[nameof(modelProps.Position)] = !comboBox1.SelectedIndex.Equals(-1); NotifyChanges(); };
        }

        private async void DeleteButtonClick(object sender, EventArgs e)
        {
            using (UserData data = new UserData(connectionString))
                await data.DeleteDataByGuidAsync(user.ID);
            parentForm.UpdateUsersList();
            Dispose();
        }

        private void NotifyChanges() => AcceptChangesButton.Enabled = modelHasValue.All(m => m.Value.Equals(true));

        private void UserManageUserControl_Load(object sender, EventArgs e)
        {
            using (PositionData data = new PositionData(connectionString))
                positions = data.GetDataCollection();

            comboBox1.Items.Clear();
            foreach (PositionModel position in positions)
                comboBox1.Items.Add(position.Name);

            textBox1.Text = user.FirstName;
            textBox2.Text = user.MiddleName;
            textBox3.Text = user.LastName;
            maskedTextBox1.Text = user.ContactNumber;

            if (!user.ID.Equals(Guid.Empty))
                comboBox1.SelectedItem = positions.FirstOrDefault(p=>p.ID.Equals(user.Position.ID)).Name;
        }

        private async void AcceptChangesButtonClick(object sender, EventArgs e)
        {
            if (!user.ID.Equals(Guid.Empty))
                await UpdateMethod();
            else
                await InsertMethod();
            return;
        }

        private async Task UpdateMethod()
        {
            using (UserData data = new UserData(connectionString))
            {
                UserModel updated = user;
                updated.FirstName = textBox1.Text;
                updated.MiddleName = textBox2.Text;
                updated.LastName = textBox3.Text;
                updated.Position = positions.FirstOrDefault(p => p.Name.Equals(comboBox1.SelectedItem));
                updated.ContactNumber = maskedTextBox1.Text;
                await data.UpdateDataAsync(updated, nameof(SQLEnums.StoredProcedureNames.СотрудникиИзменить));
            }
            parentForm.UpdateUsersList(parentForm.UsersListSelectedIndex);
            Dispose();
        }

        private async Task InsertMethod()
        {
            using (UserData data = new UserData(connectionString))
            {
                UserModel user = new UserModel()
                {
                    ID = Guid.NewGuid(),
                    FirstName = textBox1.Text,
                    MiddleName = textBox2.Text,
                    LastName = textBox3.Text,
                    Position = positions.FirstOrDefault(p => p.Name.Equals(comboBox1.SelectedItem)),
                    ContactNumber = maskedTextBox1.Text
                };
                await data.InsertDataAsync(user, nameof(SQLEnums.StoredProcedureNames.СотрудникиДобавить));
            }
            parentForm.UpdateUsersList(parentForm.UsersListSelectedIndex);
            Dispose();
        }

        private void CloseViewClick(object sender, EventArgs e)
        {
            parentForm.UpdateUsersList(parentForm.UsersListSelectedIndex);
            Dispose();
        }
    }
}
