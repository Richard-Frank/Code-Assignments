namespace Lab_Exercise_2.UI
{
    partial class frmArrays
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lstItems = new System.Windows.Forms.ListBox();
            this.btnAddArray1 = new System.Windows.Forms.Button();
            this.btnAddArray2 = new System.Windows.Forms.Button();
            this.btnAddArray3 = new System.Windows.Forms.Button();
            this.btnAddArray4 = new System.Windows.Forms.Button();
            this.btnAddArray5 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDisplayArray = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblElementsNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblElementsSum = new System.Windows.Forms.Label();
            this.lblElementsAverage = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 240);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(403, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 12);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(115, 20);
            this.txtInput.TabIndex = 1;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // lstItems
            // 
            this.lstItems.FormattingEnabled = true;
            this.lstItems.Location = new System.Drawing.Point(133, 12);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(121, 121);
            this.lstItems.TabIndex = 2;
            // 
            // btnAddArray1
            // 
            this.btnAddArray1.Location = new System.Drawing.Point(12, 38);
            this.btnAddArray1.Name = "btnAddArray1";
            this.btnAddArray1.Size = new System.Drawing.Size(115, 23);
            this.btnAddArray1.TabIndex = 3;
            this.btnAddArray1.Text = "Add to Array #1";
            this.btnAddArray1.UseVisualStyleBackColor = true;
            this.btnAddArray1.Click += new System.EventHandler(this.btnAddArray1_Click);
            // 
            // btnAddArray2
            // 
            this.btnAddArray2.Location = new System.Drawing.Point(12, 67);
            this.btnAddArray2.Name = "btnAddArray2";
            this.btnAddArray2.Size = new System.Drawing.Size(115, 23);
            this.btnAddArray2.TabIndex = 4;
            this.btnAddArray2.Text = "Add to Array #2";
            this.btnAddArray2.UseVisualStyleBackColor = true;
            this.btnAddArray2.Click += new System.EventHandler(this.btnAddArray2_Click);
            // 
            // btnAddArray3
            // 
            this.btnAddArray3.Location = new System.Drawing.Point(12, 96);
            this.btnAddArray3.Name = "btnAddArray3";
            this.btnAddArray3.Size = new System.Drawing.Size(115, 23);
            this.btnAddArray3.TabIndex = 5;
            this.btnAddArray3.Text = "Add to Array #3";
            this.btnAddArray3.UseVisualStyleBackColor = true;
            this.btnAddArray3.Click += new System.EventHandler(this.btnAddArray3_Click);
            // 
            // btnAddArray4
            // 
            this.btnAddArray4.Location = new System.Drawing.Point(12, 125);
            this.btnAddArray4.Name = "btnAddArray4";
            this.btnAddArray4.Size = new System.Drawing.Size(115, 23);
            this.btnAddArray4.TabIndex = 6;
            this.btnAddArray4.Text = "Add to Array #4";
            this.btnAddArray4.UseVisualStyleBackColor = true;
            this.btnAddArray4.Click += new System.EventHandler(this.btnAddArray4_Click);
            // 
            // btnAddArray5
            // 
            this.btnAddArray5.Location = new System.Drawing.Point(12, 154);
            this.btnAddArray5.Name = "btnAddArray5";
            this.btnAddArray5.Size = new System.Drawing.Size(115, 23);
            this.btnAddArray5.TabIndex = 7;
            this.btnAddArray5.Text = "Add to Array #5";
            this.btnAddArray5.UseVisualStyleBackColor = true;
            this.btnAddArray5.Click += new System.EventHandler(this.btnAddArray5_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(316, 214);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDisplayArray
            // 
            this.btnDisplayArray.Location = new System.Drawing.Point(280, 9);
            this.btnDisplayArray.Name = "btnDisplayArray";
            this.btnDisplayArray.Size = new System.Drawing.Size(111, 23);
            this.btnDisplayArray.TabIndex = 9;
            this.btnDisplayArray.Text = "Display Array";
            this.btnDisplayArray.UseVisualStyleBackColor = true;
            this.btnDisplayArray.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "# of Elements";
            // 
            // lblElementsNumber
            // 
            this.lblElementsNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblElementsNumber.Location = new System.Drawing.Point(280, 48);
            this.lblElementsNumber.Name = "lblElementsNumber";
            this.lblElementsNumber.Size = new System.Drawing.Size(100, 24);
            this.lblElementsNumber.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Sum of Elements";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Average of Elements";
            // 
            // lblElementsSum
            // 
            this.lblElementsSum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblElementsSum.Location = new System.Drawing.Point(280, 109);
            this.lblElementsSum.Name = "lblElementsSum";
            this.lblElementsSum.Size = new System.Drawing.Size(100, 24);
            this.lblElementsSum.TabIndex = 14;
            // 
            // lblElementsAverage
            // 
            this.lblElementsAverage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblElementsAverage.Location = new System.Drawing.Point(280, 167);
            this.lblElementsAverage.Name = "lblElementsAverage";
            this.lblElementsAverage.Size = new System.Drawing.Size(100, 24);
            this.lblElementsAverage.TabIndex = 15;
            // 
            // frmArrays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 262);
            this.Controls.Add(this.lblElementsAverage);
            this.Controls.Add(this.lblElementsSum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblElementsNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDisplayArray);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAddArray5);
            this.Controls.Add(this.btnAddArray4);
            this.Controls.Add(this.btnAddArray3);
            this.Controls.Add(this.btnAddArray2);
            this.Controls.Add(this.btnAddArray1);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmArrays";
            this.Text = "Arrays";
            this.Load += new System.EventHandler(this.frmArrays_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.Button btnAddArray1;
        private System.Windows.Forms.Button btnAddArray2;
        private System.Windows.Forms.Button btnAddArray3;
        private System.Windows.Forms.Button btnAddArray4;
        private System.Windows.Forms.Button btnAddArray5;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDisplayArray;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblElementsNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblElementsSum;
        private System.Windows.Forms.Label lblElementsAverage;
    }
}

