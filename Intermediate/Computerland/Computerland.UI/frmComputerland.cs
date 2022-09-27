using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Computerland.BL;

namespace Computerland.UI
{
    public partial class frmComputerland : Form
    {

        private CComputerList oComputers;
        private CComputerTypeList oComputerTypeList;

        public frmComputerland()
        {
            InitializeComponent();
        }


        //This is the Get Computers button.
        private void button1_Click(object sender, EventArgs e)
        {
            // Instantiate the ComputerList variable.
            oComputers = new CComputerList();

            try
            {
                //Load the Computers.
                oComputers.LoadAll();

                //Clears out the DataGrid, then binds the computers to the Data Grid View
                dgvComputers.DataSource = null;
                dgvComputers.DataSource = oComputers.Computers;

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

        private void dgvComputers_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                CComputer oComputer = oComputers[dgvComputers.CurrentRow.Index];

                txtID.Text = oComputer.Id.ToString();
                txtBrand.Text = oComputer.Brand;
                txtSerialNumber.Text = oComputer.SerialNumber;
                txtMemory.Text = oComputer.Memory.ToString();
                //txtType.Text = oComputer.Type.ToString();
                txtModel.Text = oComputer.Model;
            }
            catch (Exception ex)
            {

                lblStatus.Text = ex.Message;
            }
        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveComputersXml_Click(object sender, EventArgs e)
        {
            try
            {
                CComputerList oComputer = new CComputerList();

                oComputer.SaveAllXML();

            }
            catch (Exception ex)
            {
                
                lblStatus.Text = ex.Message;
            }
        }

        private void btnLoadComputersXml_Click(object sender, EventArgs e)
        {
            try
            {
                CComputerList oComputer = new CComputerList();

                oComputer.LoadAllXML();

                //Clears out the DataGrid, then binds the computers to the Data Grid View
                dgvComputers.DataSource = null;
                dgvComputers.DataSource = oComputers.Computers;
            }
            catch (Exception ex)
            {
                
                lblStatus.Text = ex.Message;
            }
        }

        private void frmComputerland_Load(object sender, EventArgs e)
        {
            if (oComputers == null)
            {
                oComputers = new CComputerList();
                oComputers.Populate();
            }

            //Make a oCComputerTypes object.
            oComputerTypeList = new CComputerTypeList();

            //oComputerTypeList.Add(new CComputerType("10", "Dell"));
            //oComputerTypeList.Add(new CComputerType("77", "Borg"));
            //oComputerTypeList.Add(new CComputerType("999", "Dudud"));
            //oComputerTypeList.Add(new CComputerType("101", "Dull"));
            //oComputerTypeList.Add(new CComputerType("123", "Cull"));

            oComputerTypeList.GetData();


            cboComputerType.DataSource = oComputerTypeList.ComputerTypes;
            cboComputerType.DisplayMember = "Description";
            cboComputerType.ValueMember = "Id";
        }

        private void cboComputerType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLoadComputers_Click(object sender, EventArgs e)
        {
            try
            {
                CComputerList oComputer = new CComputerList();

                oComputer.GetData();

                //Clears out the DataGrid, then binds the computers to the Data Grid View
                dgvComputers.DataSource = null;
                dgvComputers.DataSource = oComputers.Computers;
            }
            catch (Exception ex)
            {

                lblStatus.Text = ex.Message;
            }
        }
    }
}
