using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam1.UI
{
    public partial class frmAreaPerimeter : Form
    {

        public frmAreaPerimeter()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //Clear the status strip.
            lblStatus.Text = string.Empty;


            try
            {

                double Length = double.Parse(txtLength.Text);
                double Width = double.Parse(txtWidth.Text);
                double result;
                PerimHold(Length, Width, out result);

                double Area = Length * Width;


                txtArea.Text = Area.ToString();
                txtPerimeter.Text = result.ToString();
            }



            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
            }


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void PerimHold(double Length, double Width, out double perimeter)
        {
           perimeter = Width + Width + 2 * Length;
        }
    }
}
