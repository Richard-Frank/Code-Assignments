using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banking.BL;

namespace Banking.UI
{
    public partial class frmBanking : Form
    {

        private CCustomerList oCustomers;
        //private CCustomer oCustomer;

        public frmBanking()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBanking_Load(object sender, EventArgs e)
        {
            //Checks to see if oCustomers is empty; if empty, populates the oCustomers with customers objects.

            if (oCustomers == null)
            {
                oCustomers = new CCustomerList();
               //oCustomers.Populate();

                oCustomers.LoadAllXML();
            }

            //Binds the Listbox to values in oCustomers, and displays the FirstNames.
            lstCustomers.DataSource = oCustomers.Customers;
            lstCustomers.ValueMember = "Id";
            lstCustomers.DisplayMember = "FirstName";
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblStatus.Text = string.Empty;
            try
            {
                //Sets the values of the DataGrid to Null.
                dgvDeposits.DataSource = null;
                dgvWithdrawls.DataSource = null;

                CCustomer oCustomer = oCustomers[lstCustomers.SelectedIndex];

                txtID.Text = oCustomer.Id.ToString();
                txtFirstName.Text = oCustomer.FirstName;
                txtLastName.Text = oCustomer.LastName;
                txtSSN.Text = oCustomer.Ssn;
                txtBirthDate.Text = oCustomer.BirthDate.ToShortDateString();
                txtAge.Text = oCustomer.Age.ToString();

                //Sets the values of dgvDeposits to a customer's deposit list.
                dgvDeposits.DataSource = oCustomer.Depositlist;

                //Sets the values of dgvWithdrawls to a customer's withdrawl list.
                dgvWithdrawls.DataSource = oCustomer.Withdrawllist;

                //Formats the dates in the DepostDate and WithdrawlDate of dgvDeposits and dgvWithdrawls.
                dgvDeposits.Columns["DepositDate"].DefaultCellStyle.Format = "MM/dd/yyyy";
                dgvWithdrawls.Columns["WithdrawlDate"].DefaultCellStyle.Format = "MM/dd/yyyy";

                //Formats the numbers in the WithdrawlAmount and DepositAmount of dgvWithdrawls and dgvDeposits.
                dgvWithdrawls.Columns["WithdrawlAmount"].DefaultCellStyle.Format = "c";
                dgvDeposits.Columns["DepositAmount"].DefaultCellStyle.Format = "c";
            }
            catch (Exception ex)
            {
                
                lblStatus.Text = ex.Message;
            }

        }

        private void dgvDeposits_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dgvWithdrawls_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {// Clears the text boxes.
            txtBirthDate.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtID.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtSSN.Text = string.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {// Update existing customer. (Does nothing with the xml file.)

            try
            {
                CCustomer oCustomer = oCustomers[lstCustomers.SelectedIndex];

                oCustomer.BirthDate = Convert.ToDateTime(txtBirthDate.Text);
                oCustomer.FirstName = txtFirstName.Text;
                oCustomer.LastName = txtLastName.Text;
                oCustomer.Ssn = txtSSN.Text;

                lstCustomers.DataSource = null;
                lstCustomers.DataSource = oCustomers.Customers;
                lstCustomers.ValueMember = "Id";
                lstCustomers.DisplayMember = "FirstName";
            }
            catch (Exception ex)
            {
                
                lblStatus.Text = ex.Message;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {// Adds a customer to the list based on the input from the text boxes.

            try
            {
                // add a new customer to the list
                CCustomer oC = new CCustomer();
                oC.FirstName = "New Customer";
                oC.Id = oCustomers.GetID();
                oCustomers.Add(oC);

                // update the names in the listbox

                lstCustomers.DataSource = null;
                lstCustomers.DataSource = oCustomers.Customers;
                lstCustomers.ValueMember = "Id";
                lstCustomers.DisplayMember = "FirstName";
                
            //oC.Id = Find the max and add +1, bubble sort? Use Foreach loop. Put it in the CCustomerList.

            }
            catch (Exception ex)
            {
                
                lblStatus.Text = ex.Message;
            }
        }

        private void btnWriteToFile_Click(object sender, EventArgs e)
        {// Saves the customers to an xml file.

            try
            {
                oCustomers.SaveAllXML();
            }
            catch (Exception ex)
            {
                
                lblStatus.Text = ex.Message;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {// Deletes a customer from the Listbox.

            try
            {
                oCustomers.Remove(oCustomers[lstCustomers.SelectedIndex]);
                lstCustomers.DataSource = null;
                lstCustomers.DataSource = oCustomers.Customers;
                lstCustomers.ValueMember = "Id";
                lstCustomers.DisplayMember = "FirstName";

                // select the last item in the listbox
                lstCustomers.SetSelected(lstCustomers.Items.Count - 1, true);
            }
            catch (Exception ex)
            {
                
                lblStatus.Text = ex.Message;
            }
        }
    }
}
