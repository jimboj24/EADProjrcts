using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProStatClassLib;

namespace ProStats
{
    
    public partial class FrmGradeSheet : Form
    {
        //Grades
        
        int parsedIntiger;

        Grades grades = new Grades();
        public FrmGradeSheet()
        {
            InitializeComponent();
        }

        private void txtAcadamicYr1_Click(object sender, EventArgs e)
        {
            lblMessage.Visible = true;
        }

        private void txtAcadamicYr1_Leave(object sender, EventArgs e)
        {
            //int parsedIntiger;
            //Validate academic year to accept numbers only
            if(!int.TryParse(txtAcadamicYr1.Text, out parsedIntiger))
            {
                MessageBox.Show("This is a number only field ", "Alert");
                txtAcadamicYr1.Focus();
                return;
            }
            if (txtAcadamicYr1.TextLength != 4)//Ensure academic year has 4 numbers
            {
                MessageBox.Show("Academic year must be 4 numbers ", "Alert");
                txtAcadamicYr1.Focus();
                return;
            }
            lblMessage.Visible = false;

        }

        private void txtAcadamicYr2_Click(object sender, EventArgs e)
        {
            lblMessage.Visible = true;
        }

        private void txtAcadamicYr2_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(txtAcadamicYr2.Text, out parsedIntiger))
            {
                MessageBox.Show("This is a number only field ", "Alert");
                txtAcadamicYr2.Focus();
                return;
            }
            if (txtAcadamicYr2.TextLength != 4)//Ensure academic year has 4 numbers
            {
                MessageBox.Show("Academic year must be 4 numbers ", "Alert");
                txtAcadamicYr2.Focus();
                return;
            }
            lblMessage.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtStudentId_TextChanged(object sender, EventArgs e)
        {
            if (txtStudentId.Text != "")
            {
                btnPrint.Enabled = true;
            }
            else
                btnPrint.Enabled = false;

        }

        private void txtStudentId_Leave(object sender, EventArgs e)
        {
            if (txtStudentId.Text == "")
            {
               // btnPrint.Enabled = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtAcadamicYr1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //txtStudentId.Text = grades.StudentId.ToString();
            //lblFullName.Text = grades.FirstName + "" + grades.LastName;
            //txtProgramme.Text = grades.Programme;
            //grades.Semister = int.Parse(cboSemister.SelectedItem.ToString());
            //grades.Year = int.Parse(cboYear.SelectedItem.ToString());
            //grades.AcademicYear1 = int.Parse(txtAcadamicYr1.Text);
            //txtCode1.Text = grades.CourseCode;
            //txtCourse1.Text = grades.Course;
            //txtEw1.Text = grades.Ew.ToString();
            //txtCw1.Text = grades.Cw.ToString();
            //txtMa1.Text = grades.ModuleAvg.ToString();

            MessageBox.Show("Student ID" + "" + txtStudentId.Text + Environment.NewLine + "GPA" + grades.Gpa.ToString()+
                Environment.NewLine+"Date Created " + grades.Created);
        }

        private void FrmGradeSheet_Load(object sender, EventArgs e)
        {
            txtStudentId.Text = grades.StudentId.ToString();
            lblFullName.Text = grades.FirstName + "" + grades.LastName;
            txtProgramme.Text = grades.Programme;
            txtAcadamicYr1.Text = grades.AcademicYear1.ToString();
           // grades.Semister = int.Parse(cboSemister.SelectedItem.ToString());
            //grades.Year = int.Parse(cboYear.SelectedItem.ToString());
            //grades.AcademicYear1 = int.Parse(txtAcadamicYr1.Text);
            txtCode1.Text = grades.CourseCode;
            txtCourse1.Text = grades.Course;
            txtEw1.Text = grades.Ew.ToString();
            txtCw1.Text = grades.Cw.ToString();
            txtMa1.Text = grades.ModuleAvg.ToString();
        }
    }
}
