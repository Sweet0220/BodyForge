using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BodyForgeClient.UserService;

namespace BodyForgeClient.Forms
{
    public partial class RegisterForm : Form
    {
        private UserWebServiceSoapClient userService;

        public RegisterForm()
        {
            InitializeComponent();
            this.FormClosing += goBack;
            this.userService = new UserWebServiceSoapClient();
        }

        private void goBack(Object sender, FormClosingEventArgs e)
        {
            Hide();
            LoginForm form = new LoginForm();
            form.ShowDialog();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string username = usernameInput.Text;
            string password = passwordInput.Text;
            string email = emailInput.Text;
            Users user = new Users();
            user.username = username;
            user.password = password;
            user.email = email;
            user.id = 0;
            bool result = this.userService.addUser(user);
            if (!result)
            {
                invalidCredentials.Visible = true;
            }
            else
            {
                invalidCredentials.Visible = true;
                invalidCredentials.Text = "Successfully registered! You may now close this page.";
            }
        }
    }
}
