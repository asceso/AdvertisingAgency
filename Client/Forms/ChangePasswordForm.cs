using System.Windows.Forms;
using Client.Properties;
using DatabaseLibrary.Data;
using DatabaseLibrary.Models;
using Infrastructure.Enums;
using Infrastructure.Methods;

namespace Client.Forms
{
    public partial class ChangePasswordForm : Form
    {
        private const string OldPasswordWrong = "Старый пароль не совпадает с введенным.";
        private const string NewPasswordError = "Новый пароль не совпадает.";
        private readonly string connectionString;

        private readonly UserModel user;

        public ChangePasswordForm(UserModel user, string connectionString)
        {
            InitializeComponent();
            Icon = Resources.system;
            this.user = user;
            this.connectionString = connectionString;
            textBox1.TextChanged += PasswordTBCheck;
            textBox2.TextChanged += PasswordTBCheck;
            ChangePassword.Click += ChangePasswordClick;
        }
        private void PasswordTBCheck(object sender, System.EventArgs e)
            => ChangePassword.Enabled = !string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text);
        private void ChangePasswordClick(object sender, System.EventArgs e)
        {
            if (!CheckOldPassword(user.Password, textBox0.Text))
                return;
            if (!CheckNewPasswordConfirm())
                return;
            using UserData data = new UserData(connectionString);
            UserModel newModel = user;
            newModel.Password = textBox2.Text;
            data.UpdateData(newModel, nameof(SQLEnums.StoredProcedureNames.СотрудникиИзменить));
            Close();
        }
        private bool CheckOldPassword(string old, string inputing)
        {
            if (!inputing.Equals(old))
            {
                MessageBoxImplementation.ShowErrorMessage(OldPasswordWrong);
                return false;
            }
            return true;
        }
        private bool CheckNewPasswordConfirm()
        {
            if (!textBox1.Text.Equals(textBox2.Text))
            {
                MessageBoxImplementation.ShowErrorMessage(NewPasswordError);
                return false;
            }
            return true;
        }
    }
}
