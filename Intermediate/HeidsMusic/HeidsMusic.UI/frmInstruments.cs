using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HeidsMusic.BL;
using HeidsMusic.Enumerations;

namespace Heids.UI
{
    public partial class frmInstruments : Form
    {
        CBrasses oBrasses;
        CWoodwinds oWoodwinds;
        public frmInstruments()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            oBrasses = new CBrasses();
            oWoodwinds = new CWoodwinds();
        }


        private void btnFillBrass_Click(object sender, EventArgs e)
        {
            // Parameters : Finish, Valvecount, Cost, Manufacturer, Model, Instrument Type
            CBrass oBrass = new CBrass("Brass", 3, 34, "Getzen", "Seversen", InstrumentType.Trumpet);
            oBrasses.Add(oBrass);

            // Parameters : Finish, Valvecount, Cost, Manufacturer, Model, Instrument Type
            oBrass = new CBrass("Silver", 2, 456, "Bundy", "G6", InstrumentType.Tuba);
            oBrasses.Add(oBrass);

            dgvBrass.AutoGenerateColumns = true;
            dgvBrass.DataSource = oBrasses.Brasses;
        }

        private void btnFillWoodwinds_Click(object sender, EventArgs e)
        {
            // Parameters : Reed Type, Reed Count, Cost, Manufacturer, Model, Instrument Type
            CWoodwind oWoodwind = new CWoodwind("Single", 1, 340, "Clarinets and Stuff", "Glenwour", InstrumentType.Bassoon);
            oWoodwinds.Add(oWoodwind);

            // Parameters : Reed Type, Reed Count, Cost, Manufacturer, Model, Instrument Type
            oWoodwind = new CWoodwind("Double", 2, 456, "We be Reeds", "G6", InstrumentType.Clarinet);
            oWoodwinds.Add(oWoodwind);

            dgvWoodwinds.AutoGenerateColumns = true;
            dgvWoodwinds.DataSource = oWoodwinds.Woodwinds;
        }

        private void btnSaveBrass_Click(object sender, EventArgs e)
        {
            try
            {
                oBrasses.SaveXML();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLoadBrass_Click(object sender, EventArgs e)
        {
            try
            {
                oBrasses.LoadXML();
                dgvBrass.AutoGenerateColumns = true;
                dgvBrass.DataSource = oBrasses.Brasses;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLoadWoodwinds_Click(object sender, EventArgs e)
        {
            try
            {
                oWoodwinds.LoadXML();
                dgvWoodwinds.AutoGenerateColumns = true;
                dgvWoodwinds.DataSource = oWoodwinds.Woodwinds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSaveWoodwinds_Click(object sender, EventArgs e)
        {
            try
            {
                oWoodwinds.SaveXML();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClearBrass_Click(object sender, EventArgs e)
        {
            dgvBrass.DataSource = null;
            oBrasses = new CBrasses();

        }

        private void btnClearWoodwinds_Click(object sender, EventArgs e)
        {
            dgvWoodwinds.DataSource = null;
            oWoodwinds = new CWoodwinds();

        }
    }
}
