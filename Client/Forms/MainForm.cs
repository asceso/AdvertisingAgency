using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Client.Properties;
using Client.UserControls;
using Client.UserControls.GenericControls;
using DatabaseLibrary.Data;
using DatabaseLibrary.Models;
using Infrastructure.Enums;
using Infrastructure.Methods;
using Infrastructure.Models;

namespace Client.Forms
{
    public partial class MainForm : Form
    {
        #region fields and props

        internal List<UserModel> UsersCollection;
        internal SettingsModel Settings;
        internal bool ApplicationExitReady;
        internal readonly UserModel currentUser;
        internal List<PermissionModel> currentPermissions;
        internal Size CurrentControlSize { get => CurrentControl.Size; set => CurrentControl.Size = value; }
        internal int UsersListSelectedIndex => UsersList.SelectedIndex;

        #endregion fields and props

        #region ctor
        public MainForm(SettingsModel settings, UserModel user)
        {
            InitializeComponent();
            Text = $"Рекламное агентство (Пользователь: {user.Login}, {user.GetFullName})";
            Settings = settings;
            currentUser = user;
            UpdateCurrentPermissions();

            Icon = Resources.system;
            WindowState = (FormWindowState)settings.FullScreenAtStart;

            SetButtonsText(true);
            SetImages();

            ApplicationExitReady = true;

            UpdateUsersList();
            SetButtonsEnabledByRole();
        }

        #region role permisions

        private void UpdateCurrentPermissions()
        {
            using PermissionData data = new PermissionData(Settings.ConnectionString);
            currentPermissions = currentUser.Role.Name.Equals(nameof(ConstValues.RoleNames.Administrator)) ?
            data.GetDataCollection() : data.GetPermissionListByRoleGuid(currentUser.Role.ID);
        }

        private void SetButtonsEnabledByRole()
        {
            InsertUserButton.SetEnabledByPermission(currentUser.CheckPermission(DataPermissions.UserInsert, currentPermissions));
            UpdateUserButton.SetEnabledByPermission(currentUser.CheckPermission(DataPermissions.UserUpdate, currentPermissions));
            RequestTypeButton.SetEnabledByPermission(currentUser.CheckPermission(DataPermissions.RequestTypeGet, currentPermissions));
            ServicesButton.SetEnabledByPermission(currentUser.CheckPermission(DataPermissions.ServiceGet, currentPermissions));
            PositionsButton.SetEnabledByPermission(currentUser.CheckPermission(DataPermissions.PositionGet, currentPermissions));

            UsersList.UseContextMenuStripByPermission(
                currentUser.CheckPermission(DataPermissions.UserDelete, currentPermissions),
                usersContextMenu);
        }

        #endregion role permisions

        #endregion ctor

        #region form initializing

        private void SetButtonsText(bool state)
        {
            SetButtonTextInControlCollection(MainMenu, state);
            SetButtonTextInControlCollection(UsersPanel, state);
            SetButtonTextInControlCollection(ApplicationButtonsPanel, state);
            SetButtonTextInControlCollection(SystemButtons, state);
        }
        private void SetButtonTextInControlCollection(Control control, bool state)
        {
            foreach (Control item in control.Controls)
            {
                if (item is Button)
                {
                    Button current = item as Button;
                    current.Text = state ? Resources.ResourceManager.GetString($"{current.Name}Text") : Resources.NullString;
                    current.ImageAlign = state ? ContentAlignment.TopRight : ContentAlignment.TopCenter;
                }
            }
        }
        private void SetImages()
        {
            ChangeAccountButton.Image = GetSmallIconFromBitmap(Resources.change_user);
            CloseApplicationButton.Image = GetSmallIconFromBitmap(Resources.close);
            MenuStateButton.Image = GetSmallIconFromBitmap(Resources.minimize);
            InsertUserButton.Image = GetSmallIconFromBitmap(Resources.user_new);
            UpdateUserButton.Image = GetSmallIconFromBitmap(Resources.user_edit);
            ClientsButton.Image = GetSmallIconFromBitmap(Resources.clients);
            RequestButton.Image = GetSmallIconFromBitmap(Resources.request);
            RequestTypeButton.Image = GetSmallIconFromBitmap(Resources.request_type);
            ServicesButton.Image = GetSmallIconFromBitmap(Resources.service);
            PositionsButton.Image = GetSmallIconFromBitmap(Resources.position);
            SettingsButton.Image = GetSmallIconFromBitmap(Resources.settings);
        }

        internal Image GetSmallIconFromBitmap(Bitmap source) => new Bitmap(source, new Size(20, 20));

        internal void UpdateSettings() => Settings = SettingsMethods.ReadConfig();

        #endregion form initializing

        #region user controls

        internal void ChangeUserControl(UserControl opened)
        {
            CurrentControl.Controls.Clear();
            CurrentControl.Controls.Add(opened);
            CurrentControl.Controls[ConstValues.Zero].Focus();
            if (Settings.HideBorderMenu && !MenuStateButton.Text.Equals(string.Empty))
            {
                ChangeCollumnStylesAndMenuButton();
            }
        }

        private void CurrentControlResize(object sender, EventArgs e)
        {
            if (!CurrentControl.Controls.Count.Equals(ConstValues.Zero))
            {
                CurrentControl.Controls[ConstValues.Zero].Size = CurrentControlSize;
            }
        }

        private void CurrentControlControlRemoved(object sender, ControlEventArgs e)
        {
            if (!Settings.RestoreBorderMenu)
            {
                return;
            }

            if (CurrentControl.Controls.Count.Equals(ConstValues.Zero) && MenuStateButton.Text.Equals(string.Empty))
            {
                ChangeCollumnStylesAndMenuButton();
            }
        }

        #endregion user controls

        #region password context menu
        private void ChangeUserPasswordClick(object sender, EventArgs e)
        {
            ChangePasswordForm change = new ChangePasswordForm(UsersCollection[UsersList.SelectedIndex], Settings.ConnectionString);
            change.ShowDialog();
        }

        private void UsersListSelectedIndexChanged(object sender, EventArgs e)
            => changePasswordContextButton.Enabled = !UsersList.SelectedIndex.Equals(ConstValues.NullIndex);

        #endregion password context menu

        #region users

        internal void UpdateUsersList(int selected = ConstValues.NullIndex)
        {
            using (UserData data = new UserData(Settings.ConnectionString))
            {
                UsersCollection = data.GetDataCollection().Where(p => !p.Login.Equals("admin")).ToList();
            }

            UsersList.Items.Clear();
            foreach (UserModel user in UsersCollection)
            {
                UsersList.Items.Add($"{user.GetFullName}, {user.Position.Name}, {user.ContactNumber}");
            }

            UsersList.SelectedIndex = selected;
        }
        private void UsersListKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)Keys.Escape))
            {
                UsersList.SelectedIndex = ConstValues.NullIndex;
            }
        }

        #region manage

        private void UsersListMouseDoubleClick(object sender, MouseEventArgs e) => UpdateUserButton.PerformClick();
        private void UsersManageButtonClick(object sender, EventArgs e)
        {
            if (!UsersList.SelectedIndex.Equals(ConstValues.NullIndex))
            {
                ChangeUserControl(new UserManageUserControl(UsersCollection[UsersList.SelectedIndex], this, Settings.ConnectionString));
            }
        }

        private void InsertUserButtonClick(object sender, EventArgs e)
            => ChangeUserControl(new UserManageUserControl(new UserModel() { ID = Guid.Empty }, this, Settings.ConnectionString));

        #endregion manage

        #endregion users

        #region view buttons

        private void ClientsButtonClick(object sender, EventArgs e)
            => ChangeUserControl(new ClientsManageUserControl(this));

        private void RequestButtonClick(object sender, EventArgs e)
            => ChangeUserControl(new RequestUserControl(this));

        private void RequestTypeButtonClick(object sender, EventArgs e)
        {
            GenericModelUserControl<RequestTypeModel, RequestTypeData> generic = new GenericModelUserControl<RequestTypeModel, RequestTypeData>
                (
                this,
                SQLEnums.GetTableName(SQLEnums.TableNames.Типы_заявок),
                new bool[]
                {
                    currentUser.CheckPermission(DataPermissions.RequestTypeInsert, currentPermissions),
                    currentUser.CheckPermission(DataPermissions.RequestTypeUpdate, currentPermissions),
                    currentUser.CheckPermission(DataPermissions.RequestTypeDelete, currentPermissions)
                });

            ChangeUserControl(generic);
        }

        private void ServicesButtonClick(object sender, EventArgs e)
        {
            GenericModelUserControl<ServiceModel, ServiceData> generic = new GenericModelUserControl<ServiceModel, ServiceData>
                (this,
                SQLEnums.GetTableName(SQLEnums.TableNames.Услуги),
                new bool[]
                {
                    currentUser.CheckPermission(DataPermissions.ServiceInsert, currentPermissions),
                    currentUser.CheckPermission(DataPermissions.ServiceUpdate, currentPermissions),
                    currentUser.CheckPermission(DataPermissions.ServiceDelete, currentPermissions)
                });

            ChangeUserControl(generic);
        }


        private void PositionsButtonClick(object sender, EventArgs e)
        {
            GenericModelUserControl<PositionModel, PositionData> generic = new GenericModelUserControl<PositionModel, PositionData>
                (this,
                SQLEnums.GetTableName(SQLEnums.TableNames.Должности),
                new bool[]
                {
                    currentUser.CheckPermission(DataPermissions.PositionInsert, currentPermissions),
                    currentUser.CheckPermission(DataPermissions.PositionUpdate, currentPermissions),
                    currentUser.CheckPermission(DataPermissions.PositionDelete, currentPermissions)
                });

            ChangeUserControl(generic);
        }

        private void OpenSettingsView_Click(object sender, EventArgs e) => ChangeUserControl(new SettingsUserControl(this));

        #endregion view buttons

        #region border menu
        private void CloseApplicationButtonClick(object sender, EventArgs e) => Application.Exit();

        private void ChangeAccountButtonClick(object sender, EventArgs e)
        {
            ApplicationExitReady = false;
            Close();
        }

        private void MenuStateButtonClick(object sender, EventArgs e) => ChangeCollumnStylesAndMenuButton();

        private void ChangeCollumnStylesAndMenuButton()
        {
            if (MenuStateButton.Text.Equals("Свернуть меню"))
            {
                MenuStateButton.Text = string.Empty;
                MenuStateButton.Image = GetSmallIconFromBitmap(Resources.maximize);
                SetButtonsText(false);
                UsersList.Enabled = false;
                MainTable.ColumnStyles[0].Width -= 275;
            }
            else
            {
                MenuStateButton.Text = "Свернуть меню";
                MenuStateButton.Image = GetSmallIconFromBitmap(Resources.minimize);
                SetButtonsText(true);
                UsersList.Enabled = true;
                MainTable.ColumnStyles[0].Width += 275;
            }
        }

        #endregion border menu

        #region obsolete

        //[Obsolete("Тормозит систему, используйте WPF")]
        //private void GetAnim(float start, float end)
        //{
        //    step = Math.Abs(end - start) / 50;

        //    if (end - start < 0)
        //        step = -step;

        //    Timer animationTimer;
        //    animationTimer = new Timer
        //    {
        //        Interval = 1
        //    };
        //    animationTimer.Tick += new EventHandler((o, ev) =>
        //    {
        //        MainTable.ColumnStyles[0].Width += step;
        //        if (MainTable.ColumnStyles[0].Width >= 450 || MainTable.ColumnStyles[0].Width <= 100)
        //        {
        //            animationTimer.Stop();
        //        }
        //    });

        //    animationTimer.Start();
        //}

        #endregion obsolete
    }
}
