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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStudentAdd studentAdd = new FrmStudentAdd();
            studentAdd.Show();
            studentAdd.MdiParent = this;
        }

        private void gradesListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGradeSheet gradeSheet = new FrmGradeSheet();
            gradeSheet.Show();
            gradeSheet.MdiParent = this;
        }

        private void userLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLog eventsLog = new FrmLog();
            eventsLog.Show();
            eventsLog.MdiParent = this;
        }
    }
}
