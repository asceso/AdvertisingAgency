using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Client.Properties;
using DatabaseLibrary.Data;
using DatabaseLibrary.Models;
using Infrastructure.Methods;
using Infrastructure.Models;

namespace Client.Forms
{
    public partial class AuthForm : Form
    {
        #region const
        private const string NullOrEmptyLoginError = "Поле логин не должно быть пустым";
        private const string LoginLengthError = "Поле логин должно содержать не менее 3 символов";
        private const string LoginNotFoundError = "Логин отсутствует в базе данных";

        private const string NullOrEmptyPasswordError = "Поле пароль не должно быть пустым";
        private const string PasswordLengthError = "Поле пароль должно содержать не менее 3 символов";

        private const string AuthorizeSuccess = "Авторизация успешна";
        private const string AuthorizeFailed = "Пароль введен неверно, проверьте правильность ввода и повторите попытку";
        #endregion

        #region fields
        private List<UserModel> users;
        private readonly SettingsModel settings;
        #endregion 

        public AuthForm()
        {
            InitializeComponent();
            Icon = Resources.system;
            settings = SettingsMethods.ReadConfig();

            LoginBox.TextChanged += TextBoxesValueChanged;
            PasswordBox.TextChanged += TextBoxesValueChanged;

            SettingsMethods.CheckDatabaseExist(settings);

#if DEBUG
            LoginBox.TextChanged -= TextBoxesValueChanged;
            PasswordBox.TextChanged -= TextBoxesValueChanged;
            LoginBox.TextChanged += (s, e) => PasswordBox.Text = LoginBox.Text;
            PasswordBox.TextChanged += (s, e) => PasswordBox.Text = LoginBox.Text;
            LoginBox.Text = "admin";
            AuthorizeButton.Enabled = true;
            ActiveControl = AuthorizeButton;
#endif
        }

        private void AuthorizeButtonClick(object sender, EventArgs e)
        {
            using (UserData data = new UserData(settings.ConnectionString))
            {
                users = data.GetDataCollection();
            }

            string checkingResult = CheckLogin(LoginBox.Text);
            if (!checkingResult.Equals(string.Empty))
            {
                MessageBoxImplementation.ShowErrorMessage(checkingResult);
                return;
            }
            checkingResult = CheckLoginPasswordPair(LoginBox.Text, PasswordBox.Text);
            if (!checkingResult.Equals(AuthorizeSuccess))
            {
                MessageBoxImplementation.ShowErrorMessage(checkingResult);
            }
            //Run program
            MainForm main = new MainForm(settings, users.FirstOrDefault(u => u.Login.Equals(LoginBox.Text)));
            Hide();
            main.ShowDialog();
            if (main.ApplicationExitReady)
            {
                Application.Exit();
            }
            else
            {
                Show();
            }
        }

        private string CheckLogin(string login)
        {
            if (string.IsNullOrEmpty(login))
            {
                return NullOrEmptyLoginError;
            }

            if (login.Length < 3)
            {
                return LoginLengthError;
            }

            if (!users.Any(u => u.Login.Equals(login)))
            {
                return LoginNotFoundError;
            }

            return string.Empty;
        }

        private string CheckLoginPasswordPair(string login, string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                return NullOrEmptyPasswordError;
            }

            if (password.Length < 3)
            {
                return PasswordLengthError;
            }

            if (users.Any(u => u.Login.Equals(login) && u.Password.Equals(password)))
            {
                return AuthorizeSuccess;
            }
            else
            {
                return AuthorizeFailed;
            }
        }

        private void TextBoxesValueChanged(object sender, EventArgs e)
            => AuthorizeButton.Enabled = !string.IsNullOrEmpty(LoginBox.Text) && !string.IsNullOrEmpty(PasswordBox.Text);

        private void BoxesKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)Keys.Enter))
            {
                AuthorizeButton.PerformClick();
            }
        }
    }
}
