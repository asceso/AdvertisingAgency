using Client.UserControls;
using DatabaseLibrary.Data;
using DatabaseLibrary.Models;
using Infrastructure.Methods;
using Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Client.Forms
{
    public partial class MainForm : Form
    {
        private float step;
        private SettingsModel settings;
        private UserModel currentUser;
        private List<UserModel> UsersCollection;

        public Size CurrentControlSize { get => CurrentControl.Size; set => CurrentControl.Size = value; }

        public int UsersListSelectedIndex { get => UsersList.SelectedIndex; }

        public MainForm(SettingsModel settings, UserModel user)
        {

            InitializeComponent();
            this.settings = settings;
            currentUser = user;
            SettingsMethods.CheckDatabaseExist(settings);

            UpdateUsersList();
            SetUsersManageButtonsByRole(nameof(ConstValues.RoleNames.Administrator));
        }

        #region user controls

        private void ChangeUserControl(UserControl opened)
        {
            CurrentControl.Controls.Clear();
            CurrentControl.Controls.Add(opened);
            CurrentControl.Controls[ConstValues.ZeroIndex].Focus();
        }

        private void CurrentControlResize(object sender, EventArgs e)
        {
            if (!CurrentControl.Controls.Count.Equals(ConstValues.ZeroIndex))
                CurrentControl.Controls[ConstValues.ZeroIndex].Size = CurrentControlSize;
        }

        #endregion user controls

        #region password context menu
        private void ChangeUserPasswordClick(object sender, EventArgs e)
        {
            ChangePasswordForm change = new ChangePasswordForm(UsersCollection[UsersList.SelectedIndex], settings.ConnectionString);
            change.ShowDialog();
        }

        private void UsersListSelectedIndexChanged(object sender, EventArgs e)
            => changePasswordContextButton.Enabled = !UsersList.SelectedIndex.Equals(ConstValues.NullIndex);

        #endregion password context menu

        #region role permisions

        private void SetUsersManageButtonsByRole(string inputRoleName)
        {
            InsertUserButton.Enabled = currentUser.IsInRole(inputRoleName);
            UsersManageButton.Enabled = currentUser.IsInRole(inputRoleName);
            UsersList.ContextMenuStrip = currentUser.IsInRole(inputRoleName) ? usersContextMenu : null;
        }

        #endregion role permisions

        #region users

        internal void UpdateUsersList(int selected = ConstValues.NullIndex)
        {
            using (UserData data = new UserData(settings.ConnectionString))
                UsersCollection = data.GetDataCollection();

            UsersList.Items.Clear();
            foreach (var user in UsersCollection)
            {
                if (user.Login.Equals("admin"))
                    continue;
                UsersList.Items.Add($"{user.GetFullName}, {user.Position.Name}, {user.ContactNumber}");
            }
            UsersList.SelectedIndex = selected;
        }
        private void UsersListKeyPress(object sender, KeyPressEventArgs e) 
        {
            if (e.KeyChar.Equals((char)Keys.Escape)) 
                UsersList.SelectedIndex = ConstValues.NullIndex;
        }

        #region manage

        private void UsersListMouseDoubleClick(object sender, MouseEventArgs e) => UsersManageButton.PerformClick();
        private void UsersManageButtonClick(object sender, EventArgs e)
        {
            if (!UsersList.SelectedIndex.Equals(ConstValues.NullIndex))
                ChangeUserControl(new UserManageUserControl(UsersCollection[UsersList.SelectedIndex], this, settings.ConnectionString));
        }

        private void InsertUserButtonClick(object sender, EventArgs e)
        {
            ChangeUserControl(new UserManageUserControl(new UserModel() { ID = Guid.Empty }, this, settings.ConnectionString));
        }

        #endregion manage

        #endregion users

        private void ClientsButtonClick(object sender, EventArgs e)
        {
            ChangeUserControl(new ClientsManageUserControl(this, settings.ConnectionString));
        }

        private void MenuStateButtonClick(object sender, EventArgs e)
        {
            if (menuStateButton.Text.Equals("Свернуть меню ◀"))
            {
                menuStateButton.Text = "▶ ▶ ▶";
                MainTable.ColumnStyles[0].Width -= 350;
                //GetAnim(MainTable.ColumnStyles[0].Width, MainTable.ColumnStyles[0].Width - 400);
            }
            else
            {
                menuStateButton.Text = "Свернуть меню ◀";
                MainTable.ColumnStyles[0].Width += 350;
                //GetAnim(MainTable.ColumnStyles[0].Width, MainTable.ColumnStyles[0].Width + 400);
            }
        }

        [Obsolete("Тормозит систему, используйте WPF")]
        private void GetAnim(float start, float end)
        {
            step = Math.Abs(end - start) / 50;

            if (end - start < 0)
                step = -step;

            Timer animationTimer;
            animationTimer = new Timer();
            animationTimer.Interval = 1;
            animationTimer.Tick += new EventHandler((o, ev) =>
            {
                MainTable.ColumnStyles[0].Width += step;
                if (MainTable.ColumnStyles[0].Width >= 450 || MainTable.ColumnStyles[0].Width <= 100)
                {
                    animationTimer.Stop();
                }
            });

            animationTimer.Start();
        }
    }
}
