using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunchOrder.UI
{
    public partial class frmLunchOrder : Form
    {
        public frmLunchOrder()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closes the application.
            Application.Exit();
        }

        private void frmLunchOrder_Load(object sender, EventArgs e)
        {

        }

        private void rdbHamburger_CheckedChanged(object sender, EventArgs e)
        {
            //Reveals and unchecks the add-ons.
            chkAddon1.Visible = true;
            chkAddon1.Checked = false;
            chkAddon2.Visible = true;
            chkAddon2.Checked = false;
            chkAddon3.Visible = true;
            chkAddon3.Checked = false;

            //Displays the names and price of Hamburger add-ons.
            grpAddons.Text = "Add-On Items ($0.75/each)";
            chkAddon1.Text = "Lettuce, Tomato, and Onions";
            chkAddon2.Text = "Mayonnaise and Mustard";
            chkAddon3.Text = "French Fries";

            //Resets the SubTotal, Tax, and OrderTotal labels.
            lblOrderTotal.Text = "";
            lblSubTotal.Text = "";
            lblTax.Text = "";
        }

        private void rdbPizza_CheckedChanged(object sender, EventArgs e)
        {
            //Reveals and unchecks the add-ons.
            chkAddon1.Visible = true;
            chkAddon1.Checked = false;
            chkAddon2.Visible = true;
            chkAddon2.Checked = false;
            chkAddon3.Visible = true;
            chkAddon3.Checked = false;

            //Displays the names and price of Pizza add-ons.
            grpAddons.Text = "Add-On Items ($0.50/each)";
            chkAddon1.Text = "Pepperoni";
            chkAddon2.Text = "Sausage";
            chkAddon3.Text = "Olives";

            //Resets the SubTotal, Tax, and OrderTotal labels.
            lblOrderTotal.Text = "";
            lblSubTotal.Text = "";
            lblTax.Text = "";
        }

        private void rdbSalad_CheckedChanged(object sender, EventArgs e)
        {
            //Reveals and unchecks the add-ons
            chkAddon1.Visible = true;
            chkAddon1.Checked = false;
            chkAddon2.Visible = true;
            chkAddon2.Checked = false;
            chkAddon3.Visible = true;
            chkAddon3.Checked = false;

            //Displays the names and price of Salad add-ons.
            grpAddons.Text = "Add-On Items ($0.25/each)";
            chkAddon1.Text = "Croutons";
            chkAddon2.Text = "Bacon Bits";
            chkAddon3.Text = "Bread Sticks";

            //Resets the SubTotal, Tax, and OrderTotal labels.
            lblOrderTotal.Text = "";
            lblSubTotal.Text = "";
            lblTax.Text = "";
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            //Initialize Variables.
            double ldblSubTotal = 0;
            double ldblOrderTotal = 0;
            double ldblTax = 0;


            //Calculates the Order.


            //Calculates and displays the order for Hamburger.
            if (rdbHamburger.Checked == true)
            {
                ldblSubTotal = 6.95;

                if (chkAddon1.Checked == true)
                {
                    ldblSubTotal += .75;
                }
                if (chkAddon2.Checked == true)
                {
                    ldblSubTotal += .75;


                }
                if (chkAddon3.Checked == true)
                {
                    ldblSubTotal += .75;
                }

                ldblTax = ldblSubTotal * .0775;
                ldblOrderTotal = ldblSubTotal + ldblTax;

                lblSubTotal.Text = ldblSubTotal.ToString("C");
                lblTax.Text = ldblTax.ToString("C");
                lblOrderTotal.Text = ldblOrderTotal.ToString("C");
                


            }


            //Calculates and displays the order for Pizza.
            if (rdbPizza.Checked == true)
            {
                ldblSubTotal = 5.95;

                if (chkAddon1.Checked == true)
                {
                    ldblSubTotal += .50;
                }
                if (chkAddon2.Checked == true)
                {
                    ldblSubTotal += .50;


                }
                if (chkAddon3.Checked == true)
                {
                    ldblSubTotal += .50;
                }

                ldblTax = ldblSubTotal * .0775;
                ldblOrderTotal = ldblSubTotal + ldblTax;

                lblSubTotal.Text = ldblSubTotal.ToString("C");
                lblTax.Text = ldblTax.ToString("C");
                lblOrderTotal.Text = ldblOrderTotal.ToString("C");



            }


            //Calculates and displays the order for Salad.
            if (rdbSalad.Checked == true)
            {
                ldblSubTotal = 4.95;

                if (chkAddon1.Checked == true)
                {
                    ldblSubTotal += .25;
                }
                if (chkAddon2.Checked == true)
                {
                    ldblSubTotal += .25;


                }
                if (chkAddon3.Checked == true)
                {
                    ldblSubTotal += .25;
                }

                ldblTax = ldblSubTotal * .0775;
                ldblOrderTotal = ldblSubTotal + ldblTax;

                lblSubTotal.Text = ldblSubTotal.ToString("C");
                lblTax.Text = ldblTax.ToString("C");
                lblOrderTotal.Text = ldblOrderTotal.ToString("C");



            }
        }

        private void chkAddon1_CheckedChanged(object sender, EventArgs e)
        {
            //Resets the SubTotal, Tax, and OrderTotal labels.
            lblOrderTotal.Text = "";
            lblSubTotal.Text = "";
            lblTax.Text = "";
        }

        private void chkAddon2_CheckedChanged(object sender, EventArgs e)
        {
            //Resets the SubTotal, Tax, and OrderTotal labels.
            lblOrderTotal.Text = "";
            lblSubTotal.Text = "";
            lblTax.Text = "";
        }

        private void chkAddon3_CheckedChanged(object sender, EventArgs e)
        {
            //Resets the SubTotal, Tax, and OrderTotal labels.
            lblOrderTotal.Text = "";
            lblSubTotal.Text = "";
            lblTax.Text = "";
        }
    }
}
