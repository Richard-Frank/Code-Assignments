using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileIOAssignment.UI
{
    public partial class frmFileIO : Form
    {
        Boolean Saved = false;
        string Filepath = "";

        public frmFileIO()
        {
            InitializeComponent();


            //Due to a bug with visual studio, (Which may or may not happen when
            //you review this code,) The txtInput Textbox was completely un-selectable.
            //Any attempts to select the textbox would result in visual errors across the whole
            //form. So, I have made it so it clears the textbox upon startup.
            txtInput.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Starts the clock on startup
            lblTime.Text = DateTime.Now.ToString();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Clears the text document, and prompts a save if text is present.


            //Prompts a save if there is text in txtInput.
            if (txtInput.Text != "")
            {
                DialogResult Result = MessageBox.Show("Save File?", "File I/O", MessageBoxButtons.YesNo);
                if (Result == DialogResult.Yes)
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
                            //Saves the File and clears the textbox

                            oSW = File.CreateText(ofd.FileName);
                            oSW.WriteLine(txtInput.Text);

                            oSW.Close();
                            oSW.Dispose();
                            oSW = null;

                            txtInput.Clear();
                            Saved = false;

                        }

                        else
                        {
                            lblStatus.Text = "New File";
                            lblStatus.ForeColor = Color.Black;
                        }
                    }

                    catch (Exception ex)
                    {
                        lblStatus.Text = ex.Message;
                        lblStatus.ForeColor = Color.Red;
                    }
                }

                else if (Result == DialogResult.No)
                {
                    //Clears the textbox
                    txtInput.Clear();
                    lblStatus.Text = "New File";
                    lblStatus.ForeColor = Color.Black;
                }

            }
            else
            {
                lblStatus.Text = "New File";
                lblStatus.ForeColor = Color.Black;
            }


        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
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
                    txtInput.Text = oSR.ReadToEnd();
                    oSR.Close();
                    oSR.Dispose();
                    oSR = null;
                    lblStatus.Text = ofd.FileName;
                    lblStatus.ForeColor = Color.Black;

                    Saved = true;

                    // set filePath to equal the ofd.FileName
                    Filepath = ofd.FileName;

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

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Saved == false)
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

                        lblStatus.Text = "File Saved as " + ofd.FileName;
                        Saved = true;

                        // set filePath to equal the ofd.FileName
                        Filepath = ofd.FileName;

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

            else
            {
                try
                {
                    //Declares the StreamWriter
                    StreamWriter oSW;

                    // Writes the file
                    oSW = File.CreateText(Filepath);
                    oSW.Write(txtInput.Text);

                    oSW.Close();
                    oSW.Dispose();
                    oSW = null;

                    lblStatus.Text = "File Saved.";
                    lblStatus.ForeColor = Color.Black;

                    Saved = true;
                }
                catch (Exception ex)
                {
                    lblStatus.Text = ex.Message;
                    lblStatus.ForeColor = Color.Red;
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
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

                    lblStatus.Text = "File Saved as " + ofd.FileName;
                    Saved = true;

                    // set filePath to equal the ofd.FileName
                    Filepath = ofd.FileName;

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

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmFileIO_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult Result = MessageBox.Show("Exit File I/O? Unsaved progress may be lost!", "File I/O", MessageBoxButtons.YesNo);
            if (Result == DialogResult.Yes)
            {

            }

            else
            {
                e.Cancel = true;
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
