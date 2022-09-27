namespace Classwork.UI
{
    partial class frmArray
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
            this.lstItems = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnMakeStringArray = new System.Windows.Forms.Button();
            this.btnAges = new System.Windows.Forms.Button();
            this.btn2DArray = new System.Windows.Forms.Button();
            this.btn2DArrayHC = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnSortDecending = new System.Windows.Forms.Button();
            this.btnResize = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstItems
            // 
            this.lstItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstItems.FormattingEnabled = true;
            this.lstItems.Location = new System.Drawing.Point(122, 12);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(211, 199);
            this.lstItems.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 240);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(17, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // btnMakeStringArray
            // 
            this.btnMakeStringArray.Location = new System.Drawing.Point(12, 12);
            this.btnMakeStringArray.Name = "btnMakeStringArray";
            this.btnMakeStringArray.Size = new System.Drawing.Size(104, 23);
            this.btnMakeStringArray.TabIndex = 2;
            this.btnMakeStringArray.Text = "Make String Array";
            this.btnMakeStringArray.UseVisualStyleBackColor = true;
            this.btnMakeStringArray.Click += new System.EventHandler(this.btnMakeStringArray_Click);
            // 
            // btnAges
            // 
            this.btnAges.Location = new System.Drawing.Point(12, 41);
            this.btnAges.Name = "btnAges";
            this.btnAges.Size = new System.Drawing.Size(104, 23);
            this.btnAges.TabIndex = 3;
            this.btnAges.Text = "Show Ages";
            this.btnAges.UseVisualStyleBackColor = true;
            this.btnAges.Click += new System.EventHandler(this.btnAges_Click);
            // 
            // btn2DArray
            // 
            this.btn2DArray.Location = new System.Drawing.Point(12, 70);
            this.btn2DArray.Name = "btn2DArray";
            this.btn2DArray.Size = new System.Drawing.Size(104, 23);
            this.btn2DArray.TabIndex = 4;
            this.btn2DArray.Text = "2D Array";
            this.btn2DArray.UseVisualStyleBackColor = true;
            this.btn2DArray.Click += new System.EventHandler(this.btn2DArray_Click);
            // 
            // btn2DArrayHC
            // 
            this.btn2DArrayHC.Location = new System.Drawing.Point(12, 99);
            this.btn2DArrayHC.Name = "btn2DArrayHC";
            this.btn2DArrayHC.Size = new System.Drawing.Size(104, 23);
            this.btn2DArrayHC.TabIndex = 5;
            this.btn2DArrayHC.Text = "2D Array HC!";
            this.btn2DArrayHC.UseVisualStyleBackColor = true;
            this.btn2DArrayHC.Click += new System.EventHandler(this.btn2DArrayHC_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(12, 128);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(104, 23);
            this.btnSort.TabIndex = 6;
            this.btnSort.Text = "Sort Accending";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnSortDecending
            // 
            this.btnSortDecending.Location = new System.Drawing.Point(12, 157);
            this.btnSortDecending.Name = "btnSortDecending";
            this.btnSortDecending.Size = new System.Drawing.Size(104, 23);
            this.btnSortDecending.TabIndex = 7;
            this.btnSortDecending.Text = "Sort Decending";
            this.btnSortDecending.UseVisualStyleBackColor = true;
            this.btnSortDecending.Click += new System.EventHandler(this.btnSortDecending_Click);
            // 
            // btnResize
            // 
            this.btnResize.Location = new System.Drawing.Point(12, 186);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(104, 23);
            this.btnResize.TabIndex = 8;
            this.btnResize.Text = "Re-Size";
            this.btnResize.UseVisualStyleBackColor = true;
            this.btnResize.Click += new System.EventHandler(this.btnResize_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 214);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnResize);
            this.Controls.Add(this.btnSortDecending);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btn2DArrayHC);
            this.Controls.Add(this.btn2DArray);
            this.Controls.Add(this.btnAges);
            this.Controls.Add(this.btnMakeStringArray);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lstItems);
            this.Name = "frmArray";
            this.Text = "Array";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Button btnMakeStringArray;
        private System.Windows.Forms.Button btnAges;
        private System.Windows.Forms.Button btn2DArray;
        private System.Windows.Forms.Button btn2DArrayHC;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnSortDecending;
        private System.Windows.Forms.Button btnResize;
        private System.Windows.Forms.Button button2;
    }
}

