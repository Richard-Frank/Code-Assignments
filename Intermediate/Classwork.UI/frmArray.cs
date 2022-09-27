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
    public partial class frmArray : Form
    {
        //Declare the String 1-dimenstional Array, and initialize the contents.
        string[] Names = { "Homer", "Marge", "Bart", "Lisa", "Maggie" };

        //string[] Names = newstring[5];

        //Declare a 1-dimenstional array for ages/
        int[] Ages = { 10, 23, 99, 50, 123, 666 };

        public frmArray()
        {
            InitializeComponent();
        }

        private void btnMakeStringArray_Click(object sender, EventArgs e)
        {
            lstItems.Items.Clear();
            lstItems.Items.Add(Names[0]);
            lstItems.Items.Add(Names[1]);
            lstItems.Items.Add(Names[2]);
            lstItems.Items.Add(Names[3]);
            lstItems.Items.Add(Names[4]);
        }

        private void btnAges_Click(object sender, EventArgs e)
        {
            DisplayArray();

        }

        private void DisplayArray()
        {
            //Clears the text box.
            lstItems.Items.Clear();

            //For loop with hardcoded end points.
            ///   for (int iCnt = 0; iCnt <= 5; iCnt++)
            ///   {
            ///       lstItems.Items.Add(Ages[iCnt]);
            /// }


            //Loop through dynamically
            /// for (int iCnt = Ages.GetLowerBound(0); iCnt <= Ages.GetUpperBound(0); iCnt++)
            ///  {
            ///      lstItems.Items.Add(Ages[iCnt]);
            ///  }
            ///  



            foreach (int Age in Ages)
            {
                lstItems.Items.Add(Age);
            }
        }

        private void btn2DArray_Click(object sender, EventArgs e)
        {
            //Clears the list box.
            lstItems.Items.Clear();

            //Create a 2D Array with 2 X 3 (2 rows and three columbs)

            double[,] gpas = new double[2, 3];

            gpas[0, 0] = 2.3;
            gpas[0, 1] = 3.75;
            gpas[0, 2] = 2.9;
            gpas[1, 0] = 1.4;
            gpas[1, 1] = 4;
            gpas[1, 2] = 3.23;

            //ERROR!: gpas[4, 4] = 0;


            for (int iRow = 0; iRow <= gpas.GetUpperBound(0); iRow+=1 )
            {
                for (int iCol = gpas.GetLowerBound(1); iCol <= gpas.GetUpperBound(1); iCol+=1)
                {
                    string s = "[" + iRow.ToString() + "," + iCol.ToString()
                                + "] " + gpas[iRow, iCol].ToString();

                    lstItems.Items.Add(s);

                }
            }

        }

        private void btn2DArrayHC_Click(object sender, EventArgs e)
        {// Hard Coded 2D Array.


            //Clears the list box.
            lstItems.Items.Clear();

            //Create a 2D Array with 2 X 3 (2 rows and three columbs)

            double[,] gpas = { { 2.3, 3.75, 2.9 }, { 1.4, 4, 3.23 } };

           // gpas[0, 0] = 2.3;
           // gpas[0, 1] = 3.75;
           // gpas[0, 2] = 2.9;
           // gpas[1, 0] = 1.4;
           // gpas[1, 1] = 4;
           // gpas[1, 2] = 3.23;

            for (int iRow = 0; iRow <= gpas.GetUpperBound(0); iRow += 1)
            {
                for (int iCol = gpas.GetLowerBound(1); iCol <= gpas.GetUpperBound(1); iCol += 1)
                {
                    string s = "[" + iRow.ToString() + "," + iCol.ToString()
                                + "] " + gpas[iRow, iCol].ToString();

                    lstItems.Items.Add(s);

                }
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            //Clears the list box.
            lstItems.Items.Clear();

            // Sort the Ages array!
            Array.Sort(Ages);

            DisplayArray();
        }

        private void btnSortDecending_Click(object sender, EventArgs e)
        {
            //Sorts the Ages Array.
            Array.Sort(Ages); 
            
            //Reverses the Ages Array.
            Array.Reverse(Ages);

            DisplayArray();
        }

        private void btnResize_Click(object sender, EventArgs e)
        {
            //Re-Size the array ... Sort of.

            //Ages 6

            Array.Resize(ref Ages, 10);

            DisplayArray();
        }
    }
}
