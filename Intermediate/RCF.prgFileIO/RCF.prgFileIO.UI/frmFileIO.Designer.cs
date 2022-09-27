namespace RCF.prgFileIO.UI
{
    partial class frmFileIO
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
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnReadAll = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDialogRead = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnReadByLine = new System.Windows.Forms.Button();
            this.btnDialogWrite = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnColorForEach = new System.Windows.Forms.Button();
            this.btnChangeFont = new System.Windows.Forms.Button();
            this.btnBold = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(12, 15);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(88, 23);
            this.btnWrite.TabIndex = 0;
            this.btnWrite.Text = "&Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnReadAll
            // 
            this.btnReadAll.Location = new System.Drawing.Point(12, 44);
            this.btnReadAll.Name = "btnReadAll";
            this.btnReadAll.Size = new System.Drawing.Size(88, 23);
            this.btnReadAll.TabIndex = 1;
            this.btnReadAll.Text = "&Read All";
            this.btnReadAll.UseVisualStyleBackColor = true;
            this.btnReadAll.Click += new System.EventHandler(this.btnReadAll_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 73);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDialogRead
            // 
            this.btnDialogRead.Location = new System.Drawing.Point(12, 102);
            this.btnDialogRead.Name = "btnDialogRead";
            this.btnDialogRead.Size = new System.Drawing.Size(88, 23);
            this.btnDialogRead.TabIndex = 3;
            this.btnDialogRead.Text = "D&ialog Read";
            this.btnDialogRead.UseVisualStyleBackColor = true;
            this.btnDialogRead.Click += new System.EventHandler(this.btnDialogRead_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(160, 18);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(447, 107);
            this.txtInput.TabIndex = 4;
            this.txtInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblOutput
            // 
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutput.Location = new System.Drawing.Point(160, 138);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(447, 111);
            this.lblOutput.TabIndex = 5;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 321);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(613, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // btnReadByLine
            // 
            this.btnReadByLine.Location = new System.Drawing.Point(12, 131);
            this.btnReadByLine.Name = "btnReadByLine";
            this.btnReadByLine.Size = new System.Drawing.Size(88, 23);
            this.btnReadByLine.TabIndex = 7;
            this.btnReadByLine.Text = "Read By Line";
            this.btnReadByLine.UseVisualStyleBackColor = true;
            this.btnReadByLine.Click += new System.EventHandler(this.btnReadByLine_Click);
            // 
            // btnDialogWrite
            // 
            this.btnDialogWrite.Location = new System.Drawing.Point(12, 160);
            this.btnDialogWrite.Name = "btnDialogWrite";
            this.btnDialogWrite.Size = new System.Drawing.Size(88, 23);
            this.btnDialogWrite.TabIndex = 8;
            this.btnDialogWrite.Text = "Dialog Write";
            this.btnDialogWrite.UseVisualStyleBackColor = true;
            this.btnDialogWrite.Click += new System.EventHandler(this.btnDialogWrite_Click);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(12, 189);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(88, 23);
            this.btnColor.TabIndex = 9;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnColorForEach
            // 
            this.btnColorForEach.Location = new System.Drawing.Point(12, 218);
            this.btnColorForEach.Name = "btnColorForEach";
            this.btnColorForEach.Size = new System.Drawing.Size(88, 23);
            this.btnColorForEach.TabIndex = 10;
            this.btnColorForEach.Text = "Color For Each";
            this.btnColorForEach.UseVisualStyleBackColor = true;
            this.btnColorForEach.Click += new System.EventHandler(this.btnColorForEach_Click);
            // 
            // btnChangeFont
            // 
            this.btnChangeFont.Location = new System.Drawing.Point(12, 247);
            this.btnChangeFont.Name = "btnChangeFont";
            this.btnChangeFont.Size = new System.Drawing.Size(88, 23);
            this.btnChangeFont.TabIndex = 11;
            this.btnChangeFont.Text = "Change Font";
            this.btnChangeFont.UseVisualStyleBackColor = true;
            this.btnChangeFont.Click += new System.EventHandler(this.btnChangeFont_Click);
            // 
            // btnBold
            // 
            this.btnBold.Location = new System.Drawing.Point(12, 276);
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(88, 23);
            this.btnBold.TabIndex = 12;
            this.btnBold.Text = "BOLD";
            this.btnBold.UseVisualStyleBackColor = true;
            this.btnBold.Click += new System.EventHandler(this.btnChangeSize_Click);
            // 
            // frmFileIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 343);
            this.Controls.Add(this.btnBold);
            this.Controls.Add(this.btnChangeFont);
            this.Controls.Add(this.btnColorForEach);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnDialogWrite);
            this.Controls.Add(this.btnReadByLine);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnDialogRead);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnReadAll);
            this.Controls.Add(this.btnWrite);
            this.Name = "frmFileIO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Input/Output";
            this.Load += new System.EventHandler(this.frmFileIO_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnReadAll;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDialogRead;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Button btnReadByLine;
        private System.Windows.Forms.Button btnDialogWrite;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnColorForEach;
        private System.Windows.Forms.Button btnChangeFont;
        private System.Windows.Forms.Button btnBold;
    }
}

