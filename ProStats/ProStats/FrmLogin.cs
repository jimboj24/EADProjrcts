using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ProStats
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            
            Thread t = new Thread(new ThreadStart(splashStart));
            t.Start();
            Thread.Sleep(10000);

            InitializeComponent();

            t.Abort();
        }
        public void splashStart()
        {
            Application.Run(new FrmSplashScreen());
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnCencel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (((txtUserId.Text).ToUpper() == "ADMIN") && (txtPassword.Text == "AdminPass"))
            {
                MessageBox.Show("Login successfully");
            } else
                MessageBox.Show("Incorrect User Id or Password...  ", "Important Note",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation,
                                        MessageBoxDefaultButton.Button1);
        }
    }
}
