using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Exercise_2.UI
{
    public partial class frmArrays : Form
    {

        //Declare a 1-dimentional array for test scores.
        int[] Score = new int[5];
        
        //Declare Variables
        int Num;

        public frmArrays()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmArrays_Load(object sender, EventArgs e)
        {

        }

        private void btnAddArray1_Click(object sender, EventArgs e)
        {
            try
            {
                Score[0] = int.Parse(txtInput.Text);
                lblStatus.Text = "Score set for Array #1";
                lblStatus.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Clears the list box, and displays the values in the "Score" Array.
            lstItems.Items.Clear();
            lstItems.Items.Add(Score[0]);
            lstItems.Items.Add(Score[1]);
            lstItems.Items.Add(Score[2]);
            lstItems.Items.Add(Score[3]);
            lstItems.Items.Add(Score[4]);

            //Displays the number of elements to the user. There are 5.
            lblElementsNumber.Text = "5";

            //Clears the Displays
            lstItems.Items.Clear();
            lblElementsAverage.Text = string.Empty;
            lblElementsSum.Text = string.Empty;


            //Declares the Variables
            int Number = 0;
            int Sum = 0;
            double Average = 0;
            int count = 0;

            // display the values in the array, the number of values, the total, the average
            foreach (int num in Score)
            {
                lstItems.Items.Add(num);
                Sum = Sum + Score[count];
                count++;
                Number++;
            }
            lblElementsSum.Text = Sum.ToString();
            lblElementsNumber.Text = Number.ToString();
            Average = Sum / Number;
            lblElementsAverage.Text = Average.ToString();


        }

        private void btnAddArray2_Click(object sender, EventArgs e)
        {
            try
            {
                {
                 Score[1] = int.Parse(txtInput.Text);
                 lblStatus.Text = "Score set for Array #2";
                 lblStatus.ForeColor = Color.Black;
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void btnAddArray3_Click(object sender, EventArgs e)
        {
            try
            {
                Score[2] = int.Parse(txtInput.Text);
                lblStatus.Text = "Score set for Array #3";
                lblStatus.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void btnAddArray4_Click(object sender, EventArgs e)
        {
            try
            {
                Score[3] = int.Parse(txtInput.Text);
                lblStatus.Text = "Score set for Array #4";
                lblStatus.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void btnAddArray5_Click(object sender, EventArgs e)
        {
            try
            {
                Score[4] = int.Parse(txtInput.Text);
                lblStatus.Text = "Score set for Array #5";
                lblStatus.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
