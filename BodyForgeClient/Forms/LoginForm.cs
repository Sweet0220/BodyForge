using BodyForgeClient.AuthenticationService;
using BodyForgeClient.UserService;
using BodyForgeClient.Entity;
using BodyForgeClient.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BodyForgeClient.Forms
{
    public partial class LoginForm : Form
    {
        private AuthenticationWebServiceSoapClient authenticationService;
        private UserWebServiceSoapClient userService;

        public LoginForm()
        {
            InitializeComponent();
            authenticationService = new AuthenticationWebServiceSoapClient();
            userService = new UserWebServiceSoapClient();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameInput.Text;
            string password = passwordInput.Text;
            bool result = authenticationService.login(username, password);
            if (!result) 
            {
                invalidCredentials.Visible = true;
            }
            else
            {
                UserService.Users user = userService.getByUsername(username);
                CurrentUser.id = user.id;
                CurrentUser.username = user.username;
                CurrentUser.password = user.password;
                CurrentUser.email = user.email;
                WorkoutMenu workoutMenu = new WorkoutMenu();
                workoutMenu.Show();
                Hide();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm form = new RegisterForm();
            form.Show();
            Hide();
        }
    }
}
