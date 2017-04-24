using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProStats
{
    public partial class FrmStudentAdd : Form
    {
        public FrmStudentAdd()
        {
            InitializeComponent();
        }

        private void btnAddPhone_Click(object sender, EventArgs e)
        {
            FrmPhone phone = new FrmPhone();
            phone.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
