using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classwork.BusinessLayer1;

namespace Classwork.UI
{
    public partial class frmStudent : Form
    {

        //Declare a 'Student' object.
        CStudent oStudent;




        public frmStudent()
        {
            InitializeComponent();
        }

        private void btnMakeStudent_Click(object sender, EventArgs e)
        {
            //Instantiate the modular variable.
            oStudent = new CStudent();

            oStudent.Firstname = "Guy";
            oStudent.Lastname = "Stuudant";
            oStudent.Id = 7778777;

        }

        private void btnGetStudent_Click(object sender, EventArgs e)
        {
            lblFirstName.Text = oStudent.Firstname;
            lblLastName.Text = oStudent.Lastname;
            lblID.Text = oStudent.Id.ToString();
            lblFullName.Text = oStudent.Fullname;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            oStudent = new CStudent();
            double sideA = 3;
            double sideB = 4;
            double result;

            oStudent.CalcArea(sideA, sideB, out result);
            lblAreaCalc.Text = result.ToString();
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {

        }

        private void btnMakeStudentList_Click(object sender, EventArgs e)
        {
            CStudentList oStudentList = new CStudentList();

            try
            {
                //Make Student 1
                CStudent oStudent1 = new CStudent();
                oStudent1.Firstname = "Richard";
                oStudent1.Lastname = "Frank";
                oStudent1.Id = 100;

                oStudentList.Add(oStudent1);

                //The new CStudent uses an Overload. Remember overloads.
                CStudent oS = new CStudent(2, "Burtt", "Learningson");
                oStudentList.Add(oS);

                dgvStudents.DataSource = oStudentList.Students;
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
            }
        }
    }
}
