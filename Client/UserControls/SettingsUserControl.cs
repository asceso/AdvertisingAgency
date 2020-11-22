using System;
using System.Windows.Forms;
using Client.Forms;
using Client.Properties;
using Infrastructure.Methods;
using Infrastructure.Models;

namespace Client.UserControls
{
    public partial class SettingsUserControl : UserControl, IClosableUI
    {
        public string ConnectionString { get; set; }

        private const string LeftDockEqual = "Слева";
        private const string RightDockEqual = "Справа";
        private const string Yes = "Да";
        private const string No = "Нет";
        private const string Normal = "Обычный";
        private const string Fullscreen = "Полный экран";

        private SettingsModel settings;
        private readonly MainForm parentForm;

        public SettingsUserControl(MainForm parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            Size = parentForm.CurrentControlSize;
            closeView.Dock = (DockStyle)parentForm.Settings.CloseViewButtonPosition;

            bool RoleManagmentPemission = parentForm.currentUser.CheckPermission(DataPermissions.RolesManagment, parentForm.currentPermissions);
            RoleManagmentButton.SetEnabledByPermission(RoleManagmentPemission);

            folderDialogButton.Image = parentForm.GetSmallIconFromBitmap(Resources.folder);
            ResetModel();
        }

        private void ResetModel()
        {
            settings = SettingsMethods.ReadConfig();
            showBorderMenu.SelectedItem = ConvertBooleanToStringVariants(settings.HideBorderMenu, Yes, No);
            showAdditionalInfo.SelectedItem = ConvertBooleanToStringVariants(settings.ShowAdditionalInfo, Yes, No);
            showOnlyOwnRequests.SelectedItem = ConvertBooleanToStringVariants(settings.ShowOnlyOwnRequests, Yes, No);
            restoreBorderMenu.SelectedItem = ConvertBooleanToStringVariants(settings.RestoreBorderMenu, Yes, No);

            closeViewButtonPosition.SelectedItem = ConvertIntEnumToString(
                settings.CloseViewButtonPosition,
                (int)DockStyle.Left,
                (int)DockStyle.Right,
                typeof(DockStyle));

            fullScreenAtStart.SelectedItem = ConvertIntEnumToString(
                settings.FullScreenAtStart,
                (int)FormWindowState.Normal,
                (int)FormWindowState.Maximized,
                typeof(FormWindowState));

            fileFolderPath.Text = settings.FileFolderPath;
        }

        #region converters
        private string ConvertBooleanToStringVariants(bool source, string variantOne, string variantTwo)
        {
            if (source.Equals(true))
            {
                return variantOne;
            }

            if (source.Equals(false))
            {
                return variantTwo;
            }

            return string.Empty;
        }
        private bool ConvertStringVariantsToBoolean(string source, string variantOne, string variantTwo)
        {
            if (source.Equals(variantOne))
            {
                return true;
            }

            if (source.Equals(variantTwo))
            {
                return false;
            }

            return false;
        }

        private int ConvertStringToIntEnum(string source, int stateOne, int stateTwo, Type selectedEnum)
        {
            if (selectedEnum.Equals(typeof(FormWindowState)))
            {
                if (source.Equals(Normal))
                {
                    return stateOne;
                }

                if (source.Equals(Fullscreen))
                {
                    return stateTwo;
                }

                return 0;
            }
            if (selectedEnum.Equals(typeof(DockStyle)))
            {
                if (source.Equals(LeftDockEqual))
                {
                    return stateOne;
                }

                if (source.Equals(RightDockEqual))
                {
                    return stateTwo;
                }

                return 0;
            }
            return 0;
        }
        private string ConvertIntEnumToString(int source, int stateOne, int stateTwo, Type selectedEnum)
        {
            if (selectedEnum.Equals(typeof(FormWindowState)))
            {
                if (source.Equals(stateOne))
                {
                    return Normal;
                }

                if (source.Equals(stateTwo))
                {
                    return Fullscreen;
                }

                return Normal;
            }
            if (selectedEnum.Equals(typeof(DockStyle)))
            {
                if (source.Equals(stateOne))
                {
                    return LeftDockEqual;
                }

                if (source.Equals(stateTwo))
                {
                    return RightDockEqual;
                }

                return Normal;
            }
            return string.Empty;
        }
        #endregion converters

        private void ReturnChangesButtonClick(object sender, EventArgs e) => ResetModel();

        private void SaveANDexitButtonClick(object sender, EventArgs e)
        {
            SettingsModel newSettings = (SettingsModel)settings.Clone();

            newSettings.HideBorderMenu = ConvertStringVariantsToBoolean(showBorderMenu.SelectedItem.ToString(), Yes, No);
            newSettings.ShowAdditionalInfo = ConvertStringVariantsToBoolean(showAdditionalInfo.SelectedItem.ToString(), Yes, No);
            newSettings.ShowOnlyOwnRequests = ConvertStringVariantsToBoolean(showOnlyOwnRequests.SelectedItem.ToString(), Yes, No);
            newSettings.RestoreBorderMenu = ConvertStringVariantsToBoolean(restoreBorderMenu.SelectedItem.ToString(), Yes, No);

            newSettings.CloseViewButtonPosition = ConvertStringToIntEnum(
                closeViewButtonPosition.SelectedItem.ToString(),
                (int)DockStyle.Left,
                (int)DockStyle.Right,
                typeof(DockStyle));

            newSettings.FullScreenAtStart = ConvertStringToIntEnum(
                fullScreenAtStart.SelectedItem.ToString(),
                (int)FormWindowState.Normal,
                (int)FormWindowState.Maximized,
                typeof(FormWindowState));

            newSettings.FileFolderPath = fileFolderPath.Text;

            SettingsMethods.SetConfig(newSettings);
            parentForm.UpdateSettings();
            closeView.PerformClick();
        }
        public void CloseViewClick(object sender, EventArgs e) => Dispose();

        private void RoleManagmentClick(object sender, EventArgs e)
            => parentForm.ChangeUserControl(new RoleManagmentUserControl(parentForm, settings));
        private void FolderDialogButtonClick(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog()
            {
                SelectedPath = fileFolderPath.Text
            };
            if (folderDialog.ShowDialog().Equals(DialogResult.OK))
            {
                fileFolderPath.Text = folderDialog.SelectedPath;
            }
        }
    }
}
