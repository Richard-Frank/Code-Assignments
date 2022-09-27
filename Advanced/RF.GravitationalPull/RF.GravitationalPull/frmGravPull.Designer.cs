namespace RF.GravitationalPull
{
    partial class frmGravPull
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
            this.cboMass1 = new System.Windows.Forms.ComboBox();
            this.cboMass2 = new System.Windows.Forms.ComboBox();
            this.txtDist = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboMass1
            // 
            this.cboMass1.FormattingEnabled = true;
            this.cboMass1.Items.AddRange(new object[] {
            "Earth",
            "Mercury",
            "Venus",
            "Mars",
            "Jupiter",
            "Saturn",
            "Uranus",
            "Neptune",
            "Human"});
            this.cboMass1.Location = new System.Drawing.Point(12, 27);
            this.cboMass1.Name = "cboMass1";
            this.cboMass1.Size = new System.Drawing.Size(152, 21);
            this.cboMass1.TabIndex = 0;
            this.cboMass1.SelectedIndexChanged += new System.EventHandler(this.cboMass1_SelectedIndexChanged);
            // 
            // cboMass2
            // 
            this.cboMass2.FormattingEnabled = true;
            this.cboMass2.Items.AddRange(new object[] {
            "Earth",
            "Mercury",
            "Venus",
            "Mars",
            "Jupiter",
            "Saturn",
            "Uranus",
            "Neptune",
            "Human"});
            this.cboMass2.Location = new System.Drawing.Point(12, 74);
            this.cboMass2.Name = "cboMass2";
            this.cboMass2.Size = new System.Drawing.Size(148, 21);
            this.cboMass2.TabIndex = 1;
            // 
            // txtDist
            // 
            this.txtDist.Location = new System.Drawing.Point(12, 121);
            this.txtDist.Name = "txtDist";
            this.txtDist.Size = new System.Drawing.Size(148, 20);
            this.txtDist.TabIndex = 2;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(46, 147);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(81, 29);
            this.btnCalc.TabIndex = 3;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mass 1: (Kg)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mass 2: (Kg)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Distence: (Meters)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Force: (Newtons)";
            // 
            // lblOutput
            // 
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutput.Location = new System.Drawing.Point(16, 205);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(144, 31);
            this.lblOutput.TabIndex = 8;
            // 
            // frmGravPull
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 245);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtDist);
            this.Controls.Add(this.cboMass2);
            this.Controls.Add(this.cboMass1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmGravPull";
            this.Text = "Gravitational Pull";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboMass1;
        private System.Windows.Forms.ComboBox cboMass2;
        private System.Windows.Forms.TextBox txtDist;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblOutput;
    }
}

