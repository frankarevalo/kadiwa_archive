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
    public partial class master : Form
    {
        public master()
        {
            InitializeComponent();
        }

        private void master_Load(object sender, EventArgs e)
        {
            this.Enabled = false;
            login frmLogin = new login();
            frmLogin.ShowDialog(this);
        }
    }
}
