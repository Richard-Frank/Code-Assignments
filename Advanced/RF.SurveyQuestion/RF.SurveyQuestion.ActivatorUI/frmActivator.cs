using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RF.SurveyQuestion.ActivatorUI.AdminReference;

namespace RF.SurveyQuestion.ActivatorUI
{
    public partial class frmActivator : Form
    {
        List<CQuestion> questions;
        List<CActivation> acts;

        CActivation activation;
        CQuestion question;

        int codeLength = 0;

        public frmActivator()
        {
            InitializeComponent();
            RefreshScreen();
        }

        private void RefreshScreen()
        {
            try
            {
                AdminClient client = new AdminClient();
                questions = new List<CQuestion>();
                acts = new List<CActivation>();

                questions = client.GetQuestions();
                acts = client.GetActs();

                dgvAnswer.DataSource = null;
                dgvAnswer.DataSource = acts;

                cboQuestion.DataSource = null;
                cboQuestion.DataSource = questions;
                cboQuestion.ValueMember = "Id";
                cboQuestion.DisplayMember = "Text";

                txtCode.Text = null;

                client.Close();
                client = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (codeLength == 5)
                {
                    AdminClient client = new AdminClient();

                    client.InsertAct(question.Id, dtpStart.Value, dtpEnd.Value, txtCode.Text);

                    client.Close();
                    client = null;
                    RefreshScreen();
                }

                else
                {
                    MessageBox.Show("Please enter 5 character activation code.", "Oops!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }

        }

        private void cboQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboQuestion.SelectedIndex > -1)
                {
                    question = questions[cboQuestion.SelectedIndex];
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (codeLength == 5)
                {
                    AdminClient client = new AdminClient();

                    activation = new CActivation();
                    activation = acts[dgvAnswer.CurrentRow.Index];

                    client.UpdateAct(activation.Id, question.Id, dtpStart.Value, dtpEnd.Value, txtCode.Text);

                    RefreshScreen();
                    client.Close();
                    client = null;
                }
                else
                {
                    MessageBox.Show("Please enter 5 character activation code.", "Oops!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                AdminClient client = new AdminClient();

                activation = new CActivation();
                activation = acts[dgvAnswer.CurrentRow.Index];

                client.DeleteAct(activation.Id);

                RefreshScreen();
                client.Close();
                client = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }

;        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {
            codeLength = txtCode.TextLength;
        }
    }
}
