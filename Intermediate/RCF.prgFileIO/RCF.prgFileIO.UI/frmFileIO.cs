using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace RCF.prgFileIO.UI
{
    public partial class frmFileIO : Form
    {
        public frmFileIO()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            lblStatus.Text = string.Empty;
            try
            {

                //Write out the contents to a flat file.

                //Declare the writer object
                StreamWriter oSW;

                // Attach the streamwriter to a file
                oSW = File.AppendText(@"c:\Users\Public\Newfile.txt");

                //Write the line
                oSW.WriteLine(txtInput.Text);

                //Close and clean up
                oSW.Close();
                oSW.Dispose();
                oSW = null;

                lblStatus.Text = "File Written";
                lblStatus.ForeColor = System.Drawing.Color.Blue;


            }
            catch (Exception ex)
            {

                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = System.Drawing.Color.Red;
            }


        }

        private void btnReadAll_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader oSR;

                if (File.Exists("c:\\Users\\Public\\NewFile.txt"))
                {
                    oSR = File.OpenText("c:\\Users\\Public\\NewFile.txt");
                    lblOutput.Text = oSR.ReadToEnd();

                    oSR.Close();
                    oSR.Dispose();
                    oSR = null;

                    lblStatus.Text = "Opened file!";
                    lblStatus.ForeColor = Color.Blue;

                }
                else
                {
                    lblStatus.Text = "No File!";
                    lblStatus.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {

                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = System.Drawing.Color.Red;

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("c:\\Users\\Public\\NewFile.txt"))
                {

                }
                else
                {
                    lblStatus.Text = "No File";
                }

            }
            catch (Exception ex)
            {

                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = System.Drawing.Color.Red;

            }



        }

        private void btnDialogRead_Click(object sender, EventArgs e)
        {
            try
            {
                // Dimension and instantiate a new openfiledialog object
                OpenFileDialog ofd = new OpenFileDialog();
                StreamReader oSR;

                ofd.Title = "Pick a file";
                ofd.InitialDirectory = @"C:\Users\Public";

                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    // Read and display the file.
                    oSR = File.OpenText(ofd.FileName);
                    lblOutput.Text = oSR.ReadToEnd();
                    oSR.Close();
                    oSR.Dispose();
                    oSR = null;
                }
                else
                {
                    lblStatus.Text = "No File Selected";
                    lblStatus.ForeColor = Color.Red;
                }

            }
            catch (Exception ex)
            {

                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void btnReadByLine_Click(object sender, EventArgs e)
        {
            try
            {
                // Dimension and instantiate a new openfiledialog object
                OpenFileDialog ofd = new OpenFileDialog();
                StreamReader oSR;

                ofd.Title = "Pick a file";
                ofd.InitialDirectory = @"C:\Users\Public";

                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    // Read and display the file.
                    oSR = File.OpenText(ofd.FileName);

                    // Read by line.
                    while (!oSR.EndOfStream)
                    {
                        txtInput.Text = txtInput.Text + oSR.ReadLine() + "\r\n";
                    }

                    oSR.Close();
                    oSR.Dispose();
                    oSR = null;
                }
                else
                {
                    lblStatus.Text = "No File Selected";
                    lblStatus.ForeColor = Color.Red;
                }

            }
            catch (Exception ex)
            {

                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void btnDialogWrite_Click(object sender, EventArgs e)
        {
            try
            {
                // Dimenstion and instantiate a new openfiledialog object
                SaveFileDialog ofd = new SaveFileDialog();
                StreamWriter oSW;

                ofd.Title = "Save the File";
                ofd.InitialDirectory = "@c:/Users/Public";

                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    //Saves the File

                    oSW = File.CreateText(ofd.FileName);
                    oSW.WriteLine(txtInput.Text);

                    oSW.Close();
                    oSW.Dispose();
                    oSW = null;

                }

                else
                {
                    lblStatus.Text = "No File Selected";
                    lblStatus.ForeColor = Color.Red;
                }
            }

            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {

            //Changes the color of controls and form. It looks ugly.
            try
            {
                ColorDialog ocd = new ColorDialog();
                if (ocd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    this.BackColor = ocd.Color;


                    //Changes the Controls color.
                    for (int iCnt = 0; iCnt < this.Controls.Count; iCnt++)
                    {
                        this.Controls[iCnt].BackColor = ocd.Color;
                    }
                }
            }

            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;

            }
        }

        private void btnColorForEach_Click(object sender, EventArgs e)
        {
            try
            {
                ColorDialog ocd = new ColorDialog();
                if (ocd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {



                    //Changes the color of just the buttons.
                    foreach (Control c in this.Controls)
                    {
                        if (c.GetType() == typeof(Button))
                        {
                            c.BackColor = ocd.Color;
                        }

                    }
                }
            }

            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;

            }
        }

        private void btnChangeFont_Click(object sender, EventArgs e)
        {
            try
            {
                FontDialog ocd = new FontDialog();
                if (ocd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {



                    //Changes the font of just the buttons.
                    foreach (Control c in this.Controls)
                    {
                        if (c.GetType() == typeof(Button))
                        {
                            c.Font = ocd.Font;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void btnChangeSize_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    //Changes the font style to BOLD.
                    foreach (Control c in this.Controls)
                    {
                        c.Font = new Font(c.Font, FontStyle.Bold);
                    }
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
                lblStatus.ForeColor = Color.Red;
            }
        }

        private void frmFileIO_Load(object sender, EventArgs e)
        {

        }
    }
}
