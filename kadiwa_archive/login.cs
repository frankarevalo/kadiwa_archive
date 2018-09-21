using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


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
        }

        #endregion

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
        }
    }
}
