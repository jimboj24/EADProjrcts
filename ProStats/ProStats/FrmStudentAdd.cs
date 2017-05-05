using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ProStatClassLib;

namespace ProStats
{
    public partial class FrmStudentAdd : Form
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=(local)\sqlexpress;Initial Catalog=prostat;Integrated Security=True");
        private SqlCommand cmd;
        private SqlDataAdapter adapt;
        Student student = new Student();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            student.PersonId = txtPersonId.Text;
            student.FirstName = txtFirstName.Text;
            student.LastName = txtLastName.Text;
            student.MiddleName = txtMiddleName.Text;
            student.BirthDate = dtBirthDate.Value;
            student.Phone1 = txtPhone1.Text;
            student.Phone2 = txtPhone2.Text;
            //MessageBox.Show("ID" + student.StudentId.ToString());

            if (student.PersonId != "" && student.FirstName != "" && student.LastName != "")
            {
                cmd = new SqlCommand("insert into Person(PersonId, FirstName, LastName, MiddleName, BirthDate, Phone1, Phone2, Type) values(@PersonId, @FiratName, @LastName, @MiddleName, @BirthDate, @Phone1, @Phone2, @Type)", conn);
                conn.Open();
                
                cmd.Parameters.AddWithValue("@PersonId", student.PersonId);
                cmd.Parameters.AddWithValue("@FiratName", student.FirstName);
                cmd.Parameters.AddWithValue("@LastName", student.LastName);
                cmd.Parameters.AddWithValue("@MiddleName", student.MiddleName);
                cmd.Parameters.AddWithValue("@BirthDate", student.BirthDate.Date.ToShortDateString());
                //cmd.Parameters.AddWithValue("@BirthDate", SqlDbType.Date).VTalue=student.BirthDate.Date;
                cmd.Parameters.AddWithValue("@Phone1", student.Phone1);
                cmd.Parameters.AddWithValue("@Phone2", student.Phone2);
                //cmd.Parameters.AddWithValue("@Enrolled", student.Enrolled.Date.ToShortDateString());
                cmd.Parameters.AddWithValue("@Type", student.Type);

                //cmd.Parameters.AddWithValue("@Enrolled", SqlDbType.Date).Value = student.YearEnrolled.Date;

                cmd.ExecuteNonQuery();
                conn.Close();

                cmd = new SqlCommand("insert into Student(PersonId, Enrolled) values(@PersonId, @Enrolled)", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@PersonId", student.PersonId);
                //cmd.Parameters.AddWithValue("@Type", student.Type);
                cmd.Parameters.AddWithValue("@Enrolled", student.Enrolled.Date.ToShortDateString());
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Record Inserted Successfully");
                //DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }


        }
        private void ClearData()
        {
            txtPersonId.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtMiddleName.Clear();
            //dtBirthDate.Val
            txtPhone1.Clear();
            txtPhone2.Clear();
        }
    }
}
