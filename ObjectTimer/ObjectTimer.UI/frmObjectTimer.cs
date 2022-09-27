using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectTimer.BusinessLayer;
using System.Diagnostics;
using System.Threading;

namespace ObjectTimer.UI
{
    public partial class frmObjectTimer : Form
    {
        CTimer oTimer =  new CTimer();

        public frmObjectTimer()
        {
            InitializeComponent();
        }

        private void frmObjectTimer_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Clears the Status label.
            lblStatus.Text = String.Empty;
            

            try
            {
                // Calls the timer object. And starts the timer control.
                oTimer.StartClock();
                tmrTimer.Start();
            }
            catch (Exception ex)
            {
                // Displays an error message.
                lblStatus.Text = ex.Message;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            // Clears the Status label.
            lblStatus.Text = String.Empty;

            try
            {
                // Calls the timer object. And stops the timer control.
                oTimer.StopClock();
                lblTime.Text = oTimer.Elapsedtime;
                tmrTimer.Stop();
            }
            catch (Exception ex)
            {
                // Displays an error message.
                lblStatus.Text = ex.Message;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Calls the Elaspsed Time.
            lblTime.Text = oTimer.Elapsedtime;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
