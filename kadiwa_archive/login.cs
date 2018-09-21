using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DataManager;
using Utilities;
using DataObject;

namespace kadiwa_archive
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        
        #region "Control Event"

        private void login_Load(object sender, EventArgs e)
        {
            Initialized();
            txtUsername.Select();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            if (username == "Username")
            {
                txtUsername.Text = "";
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            if (string.IsNullOrEmpty(username))
            {
                txtUsername.Text = "Username";
            }
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text.Trim();
            if (password == "Password")
            {
                txtPassword.Text = "";
                txtPassword.PasswordChar = '●';
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            string password = txtPassword.Text.Trim();
            if (string.IsNullOrEmpty(password))
            {
                txtPassword.PasswordChar = '\0';
                txtPassword.Text = "Password";
            }
        }

        #endregion

        #region "Methods"

        private void Initialized()
        {
            txtPassword.PasswordChar = '\0';
            txtUsername.Text = "Username";
            txtPassword.Text = "Password";
            lblmessage.Text = "";
        }

        #endregion

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.username = txtUsername.Text.Trim();
            users.password = txtPassword.Text.Trim();

            UsersOutput usersOutput = new UsersOutput();
            usersOutput.responsecode = ResponseCodes.Fail;

            UsersManager usersManager = new UsersManager();
            usersManager.Login(users, ref usersOutput);

            lblmessage.Text = usersOutput.message;

        }
    }
}
