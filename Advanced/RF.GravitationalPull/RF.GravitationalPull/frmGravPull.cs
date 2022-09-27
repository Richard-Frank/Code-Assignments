using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RF.GravitationalPull.BL;

namespace RF.GravitationalPull
{
    public partial class frmGravPull : Form
    {
        public frmGravPull()
        {
            InitializeComponent();
        }

        private void cboMass1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //Clear output
            lblOutput.Text = string.Empty;

            //Check Presets Mass 1
            if (cboMass1.Text == "Earth")
            {
                cboMass1.Text = "5.972e24";
            }
            if (cboMass1.Text == "Mercury")
            {
                cboMass1.Text = "3.285e23";
            }
            if (cboMass1.Text == "Venus")
            {
                cboMass1.Text = "4.867e24";
            }
            if (cboMass1.Text == "Mars")
            {
                cboMass1.Text = "6.39e23";
            }
            if (cboMass1.Text == "Jupiter")
            {
                cboMass1.Text = "1.898e27";
            }
            if (cboMass1.Text == "Saturn")
            {
                cboMass1.Text = "5.683e26";
            }
            if (cboMass1.Text == "Saturn")
            {
                cboMass1.Text = "8.681e25";
            }
            if (cboMass1.Text == "Neptune")
            {
                cboMass1.Text = "1.024e26";
            }
            if (cboMass1.Text == "Human")
            {
                cboMass1.Text = "62";
            }
            //
            //Check Presets Mass2
            if (cboMass2.Text == "Earth")
            {
                cboMass2.Text = "5.972e24";
            }
            if (cboMass2.Text == "Mercury")
            {
                cboMass2.Text = "3.285e23";
            }
            if (cboMass2.Text == "Venus")
            {
                cboMass2.Text = "4.867e24";
            }
            if (cboMass2.Text == "Mars")
            {
                cboMass2.Text = "6.39e23";
            }
            if (cboMass2.Text == "Jupiter")
            {
                cboMass2.Text = "1.898e27";
            }
            if (cboMass2.Text == "Saturn")
            {
                cboMass2.Text = "5.683e26";
            }
            if (cboMass2.Text == "Saturn")
            {
                cboMass2.Text = "8.681e25";
            }
            if (cboMass2.Text == "Neptune")
            {
                cboMass2.Text = "1.024e26";
            }
            if (cboMass2.Text == "Human")
            {
                cboMass2.Text = "62";
            }
            //

            //Calculate Gravitational Force (Mass kg, mass kg, distence meters)
            double mass1 = 0;
            double mass2 = 0;
            double dist = 0;
            double result;

            try
            {
                double.TryParse(cboMass1.Text, out mass1);
                double.TryParse(cboMass2.Text, out mass2);
                double.TryParse(txtDist.Text, out dist);

                CPullCalc.Calculate(mass1, mass2, dist, out result);

                lblOutput.Text = result.ToString();
                cboMass1.Text = mass1.ToString();
                cboMass2.Text = mass2.ToString();
                txtDist.Text = dist.ToString();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
