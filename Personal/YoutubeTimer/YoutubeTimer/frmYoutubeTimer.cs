using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeTimer.BL;

namespace YoutubeTimer
{
    public partial class frmYoutubeTimer : Form
    {

        CTimer oTimer = new CTimer();
        CTimerList oTimers;
       // TimeSpan TotalSpan;
        double SetTime = 9999;
        double TotalTime = 0;
        string SessionName;

        public frmYoutubeTimer()
        {
            InitializeComponent();
        }

        private void frmYoutubeTimer_Load(object sender, EventArgs e)
        {
            oTimers = new CTimerList();
        }

        private void btnSetTime_Click(object sender, EventArgs e)
        {
            try
            {
                SetTime = double.Parse(txtSetTime.Text);
                lblStatus.Text = "Time has been set to " + SetTime.ToString() + " Minute.";
                lblTimeSet.Text = "Time has been set to " + SetTime.ToString() + " Minute.";

                if(SetTime > 1)
                {
                  lblStatus.Text = "Time has been set to " + SetTime.ToString() + " Minutes.";
                  lblTimeSet.Text = "Time has been set to " + SetTime.ToString() + " Minutes.";
                }

                txtSetTime.Text = null;
            }
            catch (Exception ex)
            {

                lblStatus.Text = ex.Message;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStartClock_Click(object sender, EventArgs e)
        {
            // Clears the Status label.
            lblStatus.Text = String.Empty;

            try
            {
                // Calls the timer object. And starts the timer control.
                oTimer.StartClock();
                tmrTimer.Start();
                tmrTotalTime.Start();
            }
            catch (Exception ex)
            {
                // Displays an error message.
                lblStatus.Text = ex.Message;
            }
        }

        private void btnStopClock_Click(object sender, EventArgs e)
        {
            // Clears the Status label.
            lblStatus.Text = String.Empty;
            TotalTime = 0;
            lblTimerBackround.BackColor = default(Color);
            lblTime.BackColor = default(Color);
            this.BackColor = default(Color);

            try
            {

                // Calls the timer object. And stops the timer control.
                oTimer.StopClock();
                lblTime.Text = oTimer.ElapsedTime;
                tmrTimer.Stop();
                tmrTotalTime.Stop();

                CTimer oT = new CTimer();

                oT.Id = oTimers.GetId();
                oT.Name = "Session " + oT.Id.ToString() + SessionName;
                oT.SessionTime = oTimer.ElapsedTime;

                oTimers.Add(oT);

                dgvTimeList.DataSource = null;
                dgvTimeList.DataSource = oTimers.Timers;
                dgvTimeList.Columns[0].Visible = false;
                dgvTimeList.Columns[1].Visible = false;
                dgvTimeList.Columns[4].Visible = false;
                dgvTimeList.Columns[5].Visible = false;


            }
            catch (Exception ex)
            {
                // Displays an error message.
                lblStatus.Text = ex.Message;
            }
        }

        private void tmrTimer_Tick(object sender, EventArgs e)
        {
            // Calls the Elaspsed Time.
            lblTime.Text = oTimer.ElapsedTime;

            if (SetTime <= TotalTime)
            {
                lblTimerBackround.BackColor = Color.Red;
                lblTime.BackColor = Color.Red;
                this.BackColor = Color.Red;
                lblStatus.Text = "You're over time! Wrap it up!";
            }
        }

        private void tmrTotalTime_Tick(object sender, EventArgs e)
        {
            TotalTime = TotalTime + 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SessionName = " - " + txtSetName.Text;

            lblNameSet.Text = "The name has been set to " + SessionName;
            lblStatus.Text = "The name has been set to "  + SessionName;

            txtSetName.Text = null;
        }

        private void dgvTimeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Set Recording Time: To use the 'Set Recording Time' button, simply type the number of minutes you want to record into the box below, and hit the 'Set' button. Once the timer goes over the number of desired minutes the timer will turn red.", "Help", MessageBoxButtons.OK);
        }
    }
}
