namespace Computerland.UI
{
    partial class frmComputerland
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
            this.btnGetComputers = new System.Windows.Forms.Button();
            this.dgvComputers = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblSerialNumber = new System.Windows.Forms.Label();
            this.lblMemory = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtSerialNumber = new System.Windows.Forms.TextBox();
            this.txtMemory = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSaveComputersXml = new System.Windows.Forms.Button();
            this.btnLoadComputersXml = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.cboComputerType = new System.Windows.Forms.ComboBox();
            this.btnLoadComputers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComputers)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetComputers
            // 
            this.btnGetComputers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGetComputers.Location = new System.Drawing.Point(12, 210);
            this.btnGetComputers.Name = "btnGetComputers";
            this.btnGetComputers.Size = new System.Drawing.Size(128, 23);
            this.btnGetComputers.TabIndex = 0;
            this.btnGetComputers.Text = "Get Computers";
            this.btnGetComputers.UseVisualStyleBackColor = true;
            this.btnGetComputers.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvComputers
            // 
            this.dgvComputers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComputers.Location = new System.Drawing.Point(199, 12);
            this.dgvComputers.Name = "dgvComputers";
            this.dgvComputers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComputers.Size = new System.Drawing.Size(494, 164);
            this.dgvComputers.TabIndex = 1;
            this.dgvComputers.SelectionChanged += new System.EventHandler(this.dgvComputers_SelectionChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 359);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(705, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.Location = new System.Drawing.Point(12, 239);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(64, 20);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 4;
            this.lblID.Text = "ID:";
            this.lblID.Click += new System.EventHandler(this.lblID_Click);
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(47, 47);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(38, 13);
            this.lblBrand.TabIndex = 5;
            this.lblBrand.Text = "Brand:";
            // 
            // lblSerialNumber
            // 
            this.lblSerialNumber.AutoSize = true;
            this.lblSerialNumber.Location = new System.Drawing.Point(9, 128);
            this.lblSerialNumber.Name = "lblSerialNumber";
            this.lblSerialNumber.Size = new System.Drawing.Size(76, 13);
            this.lblSerialNumber.TabIndex = 6;
            this.lblSerialNumber.Text = "Serial Number:";
            // 
            // lblMemory
            // 
            this.lblMemory.AutoSize = true;
            this.lblMemory.Location = new System.Drawing.Point(38, 76);
            this.lblMemory.Name = "lblMemory";
            this.lblMemory.Size = new System.Drawing.Size(47, 13);
            this.lblMemory.TabIndex = 7;
            this.lblMemory.Text = "Memory:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(51, 154);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(34, 13);
            this.lblType.TabIndex = 8;
            this.lblType.Text = "Type:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(47, 102);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(39, 13);
            this.lblModel.TabIndex = 9;
            this.lblModel.Text = "Model:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(93, 17);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 10;
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(93, 43);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(100, 20);
            this.txtBrand.TabIndex = 11;
            // 
            // txtSerialNumber
            // 
            this.txtSerialNumber.Location = new System.Drawing.Point(93, 121);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(100, 20);
            this.txtSerialNumber.TabIndex = 12;
            // 
            // txtMemory
            // 
            this.txtMemory.Location = new System.Drawing.Point(93, 69);
            this.txtMemory.Name = "txtMemory";
            this.txtMemory.Size = new System.Drawing.Size(100, 20);
            this.txtMemory.TabIndex = 13;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(93, 95);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 15;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdate.Location = new System.Drawing.Point(12, 268);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(128, 23);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnSaveComputersXml
            // 
            this.btnSaveComputersXml.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveComputersXml.Location = new System.Drawing.Point(12, 297);
            this.btnSaveComputersXml.Name = "btnSaveComputersXml";
            this.btnSaveComputersXml.Size = new System.Drawing.Size(128, 23);
            this.btnSaveComputersXml.TabIndex = 17;
            this.btnSaveComputersXml.Text = "Save Computers XML";
            this.btnSaveComputersXml.UseVisualStyleBackColor = true;
            this.btnSaveComputersXml.Click += new System.EventHandler(this.btnSaveComputersXml_Click);
            // 
            // btnLoadComputersXml
            // 
            this.btnLoadComputersXml.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoadComputersXml.Location = new System.Drawing.Point(12, 326);
            this.btnLoadComputersXml.Name = "btnLoadComputersXml";
            this.btnLoadComputersXml.Size = new System.Drawing.Size(128, 23);
            this.btnLoadComputersXml.TabIndex = 18;
            this.btnLoadComputersXml.Text = "Load Computers XML";
            this.btnLoadComputersXml.UseVisualStyleBackColor = true;
            this.btnLoadComputersXml.Click += new System.EventHandler(this.btnLoadComputersXml_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExit.Location = new System.Drawing.Point(615, 309);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(78, 40);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cboComputerType
            // 
            this.cboComputerType.FormattingEnabled = true;
            this.cboComputerType.Location = new System.Drawing.Point(91, 151);
            this.cboComputerType.Name = "cboComputerType";
            this.cboComputerType.Size = new System.Drawing.Size(102, 21);
            this.cboComputerType.TabIndex = 20;
            this.cboComputerType.SelectedIndexChanged += new System.EventHandler(this.cboComputerType_SelectedIndexChanged);
            // 
            // btnLoadComputers
            // 
            this.btnLoadComputers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoadComputers.Location = new System.Drawing.Point(146, 297);
            this.btnLoadComputers.Name = "btnLoadComputers";
            this.btnLoadComputers.Size = new System.Drawing.Size(128, 52);
            this.btnLoadComputers.TabIndex = 21;
            this.btnLoadComputers.Text = "Load Computers DB";
            this.btnLoadComputers.UseVisualStyleBackColor = true;
            this.btnLoadComputers.Click += new System.EventHandler(this.btnLoadComputers_Click);
            // 
            // frmComputerland
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 381);
            this.Controls.Add(this.btnLoadComputers);
            this.Controls.Add(this.cboComputerType);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLoadComputersXml);
            this.Controls.Add(this.btnSaveComputersXml);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMemory);
            this.Controls.Add(this.txtSerialNumber);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblMemory);
            this.Controls.Add(this.lblSerialNumber);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgvComputers);
            this.Controls.Add(this.btnGetComputers);
            this.Name = "frmComputerland";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Computerland";
            this.Load += new System.EventHandler(this.frmComputerland_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComputers)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetComputers;
        private System.Windows.Forms.DataGridView dgvComputers;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblSerialNumber;
        private System.Windows.Forms.Label lblMemory;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtSerialNumber;
        private System.Windows.Forms.TextBox txtMemory;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSaveComputersXml;
        private System.Windows.Forms.Button btnLoadComputersXml;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox cboComputerType;
        private System.Windows.Forms.Button btnLoadComputers;
    }
}

