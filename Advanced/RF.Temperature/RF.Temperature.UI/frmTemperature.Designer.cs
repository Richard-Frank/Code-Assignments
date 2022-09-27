namespace RF.Temperature.UI
{
    partial class frmTemperature
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.rdbFahr = new System.Windows.Forms.RadioButton();
            this.rdbCels = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 27);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(130, 20);
            this.txtInput.TabIndex = 1;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(11, 153);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(69, 23);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutput.Location = new System.Drawing.Point(11, 120);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(130, 30);
            this.lblOutput.TabIndex = 5;
            // 
            // rdbFahr
            // 
            this.rdbFahr.AutoSize = true;
            this.rdbFahr.Location = new System.Drawing.Point(68, 53);
            this.rdbFahr.Name = "rdbFahr";
            this.rdbFahr.Size = new System.Drawing.Size(31, 17);
            this.rdbFahr.TabIndex = 6;
            this.rdbFahr.TabStop = true;
            this.rdbFahr.Text = "F";
            this.rdbFahr.UseVisualStyleBackColor = true;
            // 
            // rdbCels
            // 
            this.rdbCels.AutoSize = true;
            this.rdbCels.Location = new System.Drawing.Point(68, 76);
            this.rdbCels.Name = "rdbCels";
            this.rdbCels.Size = new System.Drawing.Size(32, 17);
            this.rdbCels.TabIndex = 7;
            this.rdbCels.TabStop = true;
            this.rdbCels.Text = "C";
            this.rdbCels.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Input Temperature:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Output:";
            // 
            // frmTemperature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(164, 186);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdbCels);
            this.Controls.Add(this.rdbFahr);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtInput);
            this.Name = "frmTemperature";
            this.Text = "Temperature Conversion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.RadioButton rdbFahr;
        private System.Windows.Forms.RadioButton rdbCels;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

