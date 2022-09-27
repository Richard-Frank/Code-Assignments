using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classwork.UI
{
    public partial class frmParent : Form
    {
        public frmParent()
        {
            InitializeComponent();
        }

        private void newFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Create a new child
            frmChild ofrmChild = new frmChild();

            ofrmChild.MdiParent = this;

            ofrmChild.Show();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }
    }
}
