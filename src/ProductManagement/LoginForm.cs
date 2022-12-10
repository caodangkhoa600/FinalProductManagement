using System.Security.Cryptography;
using System.Text;
using Services.AccountServices;

namespace ProductManagement
{
    public partial class LoginForm : Form
    {
        private readonly IAccountServices _accountServices;
        public LoginForm(IAccountServices accountServices)
        {
            _accountServices = accountServices;
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTxtBox.Text;
            string password = passwordTxtBox.Text;
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            UTF8Encoding utf8 = new UTF8Encoding();
            byte[] data = md5.ComputeHash(utf8.GetBytes(password));
            string hashPassword = Convert.ToBase64String(data);

            var account = _accountServices.GetAccountByUserName(username);
            if (account is not null)
            {
                if (account.Password == "123") 
                {
                    MessageBox.Show("Login in");
                    this.Hide();
                    MainForm mainForm = new MainForm();
                    mainForm.Closed += (s, args) => this.Close();
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Account Invalid");
                }
            }
        }
    }
}
