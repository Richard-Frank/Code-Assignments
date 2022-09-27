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
using System.Net.NetworkInformation;

namespace Banking.UI
{
    public partial class frmBanking : Form
    {

        private CCustomerList oCustomers;
        private bool Connected = false;
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
            //Checks to see if oCustomers is empty; if empty, fills the DataGrids
            //with infromation from the DataGrid.

            try
            {

                if (oCustomers == null)
                {
                    oCustomers = new CCustomerList();
                    //oCustomers.Populate();

                    //oCustomers.LoadAllXML();

                    oCustomers.GetData();
                }

                //Binds the customer DataGridView and hides irrelivant columns.
                dgvCustomers.DataSource = oCustomers.Customers;
                dgvCustomers.Columns[0].Visible = false;
                dgvCustomers.Columns[1].Visible = false;
                dgvCustomers.Columns[2].Visible = false;
                dgvCustomers.Columns[3].Visible = false;
                dgvCustomers.Columns[4].Visible = false;
                //lstCustomers.ValueMember = "Id";
                //lstCustomers = "FirstName";

                Connected = oCustomers.PingServer(Connected);

                if (Connected == true)
                {
                    lblStatus.Text = "Connected to server.";
                }

                if (Connected == false)
                {
                    lblStatus.Text = "Failed to connect to server!";
                }


            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;

                if (Connected == false)
                {
                    lblStatus.Text = "Failed to connect to server!";
                }
            }
            
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            lblStatus.Text = string.Empty;
            try
            {
                //Sets the values of the DataGrid to Null.
                dgvDeposits.DataSource = null;
                dgvWithdrawls.DataSource = null;

                CCustomer oCustomer = oCustomers[dgvCustomers.CurrentRow.Index];

                txtID.Text = oCustomer.Id.ToString();
                txtFirstName.Text = oCustomer.FirstName;
                txtLastName.Text = oCustomer.LastName;
                txtSSN.Text = oCustomer.Ssn;
                dtpBirthDate.Value = oCustomer.BirthDate;
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
             */

        }

        private void dgvDeposits_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dgvWithdrawls_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {// Clears the text boxes.
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtSSN.Text = string.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {// Updates an existing customer on the DataGrid, and the Database.
            try
            {

                Connected = oCustomers.PingServer(Connected);

                if (Connected == false)
                {
                    lblStatus.Text = "Failed to connect to server!";
                }

                if (Connected == true)
                {
                    CCustomer oCustomer = oCustomers[dgvCustomers.CurrentRow.Index];

                    oCustomer.BirthDate = dtpBirthDate.Value;
                    oCustomer.FirstName = txtFirstName.Text;
                    oCustomer.LastName = txtLastName.Text;
                    oCustomer.Ssn = txtSSN.Text;

                    oCustomer.Update();


                    //Refreshes the Customer Datagrid and hides unwanted columns.
                    dgvCustomers.DataSource = null;
                    dgvCustomers.DataSource = oCustomers.Customers;
                    dgvCustomers.Columns[0].Visible = false;
                    dgvCustomers.Columns[1].Visible = false;
                    dgvCustomers.Columns[2].Visible = false;
                    dgvCustomers.Columns[3].Visible = false;
                    dgvCustomers.Columns[4].Visible = false;

                    lblStatus.Text = "Customer Updated.";
                }

                //    lstCustomers.ValueMember = "Id";
                //    lstCustomers.DisplayMember = "FirstName";
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
                Connected = oCustomers.PingServer(Connected);

                if (Connected == false)
                {
                    lblStatus.Text = "Failed to connect to server!";
                }

                if (Connected == true)
                {

                    // add a new customer to the Customers DataGrid with some filler data.
                    CCustomer oC = new CCustomer();
                    oC.FirstName = "New";
                    oC.LastName = "Customer";
                    oC.Id = oCustomers.GetID();
                    oC.BirthDate = dtpBirthDate.Value;
                    oC.Ssn = "000-000-000";
                    oCustomers.Add(oC);
                    oC.Insert();

                    //Refreshes the Customer Datagrid and hides unwanted columns.
                    dgvCustomers.DataSource = null;
                    dgvCustomers.DataSource = oCustomers.Customers;
                    dgvCustomers.Columns[0].Visible = false;
                    dgvCustomers.Columns[1].Visible = false;
                    dgvCustomers.Columns[2].Visible = false;
                    dgvCustomers.Columns[3].Visible = false;
                    dgvCustomers.Columns[4].Visible = false;

                    lblStatus.Text = "Customer Added. Customer ID = " + oC.Id.ToString();
                }

                //lstCustomers.ValueMember = "Id";
                //lstCustomers.DisplayMember = "FirstName";

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
        {// Deletes a customer from the Customer DataGrid and the Database.

            try
            {
                if (Connected == false)
                {
                    lblStatus.Text = "Failed to connect to server!";
                }

                if (Connected == true)
                {
                    DialogResult Result = MessageBox.Show("Delete this customer? This also deletes from the database!", "Are You Sure?", MessageBoxButtons.YesNo);
                    if (Result == DialogResult.Yes)
                    {
                        CCustomer oCustomer = oCustomers[dgvCustomers.CurrentRow.Index];
                        oCustomer.Delete();

                        //Refreshes the Customer Datagrid and hides unwanted columns.
                        oCustomers.Remove(oCustomers[dgvCustomers.CurrentRow.Index]);
                        dgvCustomers.DataSource = null;
                        dgvCustomers.DataSource = oCustomers.Customers;
                        dgvCustomers.Columns[0].Visible = false;
                        dgvCustomers.Columns[1].Visible = false;
                        dgvCustomers.Columns[2].Visible = false;
                        dgvCustomers.Columns[3].Visible = false;
                        dgvCustomers.Columns[4].Visible = false;

                        lblStatus.Text = oCustomer.FirstName + " " + oCustomer.LastName + " " + "has been deleted!";
                    }

                    else
                    {
                        CCustomer oCustomer = oCustomers[dgvCustomers.CurrentRow.Index];
                        lblStatus.Text = oCustomer.FirstName + " " + oCustomer.LastName + " " + "was not deleted.";
                    }
                }

                //    lstCustomers.ValueMember = "Id";
                //    lstCustomers.DisplayMember = "FirstName";


                //    lstCustomers.SetSelected(lstCustomers.Items.Count - 1, true);
            }
            catch (Exception ex)
            {

                lblStatus.Text = ex.Message;
            }
        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCustomers_SelectionChanged(object sender, EventArgs e)
        {
            lblStatus.Text = string.Empty;
            try
            {
                //Sets the values of the DataGrid to Null.
                dgvDeposits.DataSource = null;
                dgvWithdrawls.DataSource = null;

                CCustomer oCustomer = oCustomers[dgvCustomers.CurrentRow.Index];

                txtID.Text = oCustomer.Id.ToString();
                txtFirstName.Text = oCustomer.FirstName;
                txtLastName.Text = oCustomer.LastName;
                txtSSN.Text = oCustomer.Ssn;
                dtpBirthDate.Value = oCustomer.BirthDate;
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

        private void btnPing_Click(object sender, EventArgs e)
        {
            try
            {
                Connected = oCustomers.PingServer(Connected);

                if (Connected == true)
                {
                    lblStatus.Text = "Connected to server.";
                }

                if (Connected == false)
                {
                    lblStatus.Text = "Failed to connect to server!";
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
            }

        }
    }

}