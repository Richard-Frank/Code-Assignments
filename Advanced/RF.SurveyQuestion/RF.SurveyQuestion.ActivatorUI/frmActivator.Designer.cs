namespace RF.SurveyQuestion.ActivatorUI
{
    partial class frmActivator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboQuestion = new System.Windows.Forms.ComboBox();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.dgvAnswer = new System.Windows.Forms.DataGridView();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblActivator = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnswer)).BeginInit();
            this.SuspendLayout();
            // 
            // cboQuestion
            // 
            this.cboQuestion.FormattingEnabled = true;
            this.cboQuestion.Location = new System.Drawing.Point(12, 25);
            this.cboQuestion.Name = "cboQuestion";
            this.cboQuestion.Size = new System.Drawing.Size(152, 21);
            this.cboQuestion.TabIndex = 0;
            this.cboQuestion.SelectedIndexChanged += new System.EventHandler(this.cboQuestion_SelectedIndexChanged);
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(289, 29);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 20);
            this.dtpStart.TabIndex = 1;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(289, 76);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpEnd.TabIndex = 2;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(12, 76);
            this.txtCode.MaxLength = 5;
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(92, 20);
            this.txtCode.TabIndex = 3;
            this.txtCode.TextChanged += new System.EventHandler(this.txtCode_TextChanged);
            // 
            // dgvAnswer
            // 
            this.dgvAnswer.AllowUserToAddRows = false;
            this.dgvAnswer.AllowUserToDeleteRows = false;
            this.dgvAnswer.AllowUserToResizeColumns = false;
            this.dgvAnswer.AllowUserToResizeRows = false;
            this.dgvAnswer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnswer.Location = new System.Drawing.Point(12, 113);
            this.dgvAnswer.Name = "dgvAnswer";
            this.dgvAnswer.ReadOnly = true;
            this.dgvAnswer.Size = new System.Drawing.Size(402, 116);
            this.dgvAnswer.TabIndex = 4;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(286, 9);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(58, 13);
            this.lblStart.TabIndex = 5;
            this.lblStart.Text = "Start Date:";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(286, 60);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(55, 13);
            this.lblEnd.TabIndex = 6;
            this.lblEnd.Text = "End Date:";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(12, 9);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(52, 13);
            this.lblQuestion.TabIndex = 7;
            this.lblQuestion.Text = "Question:";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(444, 113);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 8;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(444, 156);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(444, 198);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblActivator
            // 
            this.lblActivator.AutoSize = true;
            this.lblActivator.Location = new System.Drawing.Point(12, 60);
            this.lblActivator.Name = "lblActivator";
            this.lblActivator.Size = new System.Drawing.Size(85, 13);
            this.lblActivator.TabIndex = 11;
            this.lblActivator.Text = "Activation Code:";
            // 
            // frmActivator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 241);
            this.Controls.Add(this.lblActivator);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.dgvAnswer);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.cboQuestion);
            this.Name = "frmActivator";
            this.Text = "Activator";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnswer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboQuestion;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.DataGridView dgvAnswer;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblActivator;
    }
}

