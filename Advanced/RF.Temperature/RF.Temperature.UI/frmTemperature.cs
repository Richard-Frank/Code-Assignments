using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RF.Temperature1.BL;

namespace RF.Temperature.UI
{
    public partial class frmTemperature : Form
    {
        public frmTemperature()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double input;
            double output;

            if (rdbCels.Checked)
            {
                try
                {
                    double.TryParse(txtInput.Text, out input);
                    CTemper.ConvertToCelsius(input, out output);

                    lblOutput.Text = output.ToString();
                }

                catch (Exception ex)
                {
                    lblOutput.Text = ex.Message;
                }
            }

            if (rdbFahr.Checked)
            {
                try
                {
                    double.TryParse(txtInput.Text, out input);

                    lblOutput.Text = CTemper.ConvertToFahr(input).ToString();
                }

                catch (Exception ex)
                {
                    lblOutput.Text = ex.Message;
                }
            }

        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }
    }

    
}
