using System;
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
        enum ModelProps { FirstName, MiddleName, LastName, Position }
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
                    newControlls.Add(control);
                elemPanel.Controls.Clear();
                elemPanel.Controls.AddRange(newControlls.ToArray());
                elemPanel.Size = new Size(elemPanel.Width, elemPanel.Height + deleteButton.Height);
            }

            modelHasValue = new Dictionary<string, bool>();
            foreach (var item in Enum.GetNames(typeof(ModelProps)))
                modelHasValue.Add(item, false);

            textBox1.TextChanged += (s, e)
                => modelHasValue.DictionaryWithButtonEnableManagement(textBox1, nameof(ModelProps.FirstName), AcceptChangesButton);
            textBox2.TextChanged += (s, e)
                => modelHasValue.DictionaryWithButtonEnableManagement(textBox2, nameof(ModelProps.MiddleName), AcceptChangesButton);
            textBox3.TextChanged += (s, e)
                => modelHasValue.DictionaryWithButtonEnableManagement(textBox3, nameof(ModelProps.LastName), AcceptChangesButton);
            comboBox1.SelectedIndexChanged += (s, e)
                => modelHasValue.DictionaryWithButtonEnableManagement(comboBox1, nameof(ModelProps.Position), AcceptChangesButton);
        }

        private async void DeleteButtonClick(object sender, EventArgs e)
        {
            using (UserData data = new UserData(ConnectionString))
                await data.DeleteDataByGuidAsync(user.ID);
            parentForm.UpdateUsersList();
            Dispose();
        }

        private void UserManageUserControlLoad(object sender, EventArgs e)
        {
            using (PositionData data = new PositionData(ConnectionString))
                positions = data.GetDataCollection().Where(p => !p.Name.Equals("Директор")).ToList();

            comboBox1.Items.Clear();
            foreach (PositionModel position in positions)
                comboBox1.Items.Add(position.Name);

            textBox1.Text = user.FirstName;
            textBox2.Text = user.MiddleName;
            textBox3.Text = user.LastName;
            maskedTextBox1.Text = user.ContactNumber;

            if (!user.ID.Equals(Guid.Empty))
                comboBox1.SelectedItem = positions.FirstOrDefault(p => p.ID.Equals(user.Position.ID)).Name;
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
            using (UserData data = new UserData(ConnectionString))
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
            using (UserData data = new UserData(ConnectionString))
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
                user.Role = GetRoleByPosition(user.Position);
                await data.InsertDataAsync(user, nameof(SQLEnums.StoredProcedureNames.СотрудникиДобавить));
            }
            parentForm.UpdateUsersList(parentForm.UsersListSelectedIndex);
            Dispose();
        }

        private RoleModel GetRoleByPosition(PositionModel position)
        {
            using RoleData roleData = new RoleData(ConnectionString);
            var roles = roleData.GetDataCollection();
            if (position.Name.Equals("Менеджер") ||
                position.Name.Equals("Оператор"))
                return roles.Find(r => r.Name.Equals("Registrator"));
            if (position.Name.Equals("Инженер") ||
                position.Name.Equals("Дизайнер") ||
                position.Name.Equals("Техник") ||
                position.Name.Equals("Программист"))
                return roles.Find(r => r.Name.Equals("Operator"));
            return roles.Find(r => r.Name.Equals("nullRole"));
        }

        public void CloseViewClick(object sender, EventArgs e)
        {
            parentForm.UpdateUsersList(parentForm.UsersListSelectedIndex);
            Dispose();
        }
    }
}
