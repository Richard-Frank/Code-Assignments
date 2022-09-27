namespace Classwork.UI
{
    partial class frmStudent
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
            this.btnMakeStudent = new System.Windows.Forms.Button();
            this.btnGetStudent = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblAreaCalc = new System.Windows.Forms.Label();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.btnMakeStudentList = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMakeStudent
            // 
            this.btnMakeStudent.Location = new System.Drawing.Point(12, 11);
            this.btnMakeStudent.Name = "btnMakeStudent";
            this.btnMakeStudent.Size = new System.Drawing.Size(75, 53);
            this.btnMakeStudent.TabIndex = 0;
            this.btnMakeStudent.Text = "Make Student";
            this.btnMakeStudent.UseVisualStyleBackColor = true;
            this.btnMakeStudent.Click += new System.EventHandler(this.btnMakeStudent_Click);
            // 
            // btnGetStudent
            // 
            this.btnGetStudent.Location = new System.Drawing.Point(12, 70);
            this.btnGetStudent.Name = "btnGetStudent";
            this.btnGetStudent.Size = new System.Drawing.Size(75, 53);
            this.btnGetStudent.TabIndex = 1;
            this.btnGetStudent.Text = "Get Student";
            this.btnGetStudent.UseVisualStyleBackColor = true;
            this.btnGetStudent.Click += new System.EventHandler(this.btnGetStudent_Click);
            // 
            // lblID
            // 
            this.lblID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblID.Location = new System.Drawing.Point(172, 11);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(100, 23);
            this.lblID.TabIndex = 2;
            // 
            // lblFirstName
            // 
            this.lblFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFirstName.Location = new System.Drawing.Point(172, 41);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(100, 23);
            this.lblFirstName.TabIndex = 3;
            // 
            // lblLastName
            // 
            this.lblLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLastName.Location = new System.Drawing.Point(172, 70);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(100, 23);
            this.lblLastName.TabIndex = 4;
            // 
            // lblFullName
            // 
            this.lblFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFullName.Location = new System.Drawing.Point(172, 100);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(100, 23);
            this.lblFullName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "First Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Last Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Full Name:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 198);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblAreaCalc
            // 
            this.lblAreaCalc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAreaCalc.Location = new System.Drawing.Point(12, 224);
            this.lblAreaCalc.Name = "lblAreaCalc";
            this.lblAreaCalc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblAreaCalc.Size = new System.Drawing.Size(100, 23);
            this.lblAreaCalc.TabIndex = 11;
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(278, 11);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.Size = new System.Drawing.Size(578, 210);
            this.dgvStudents.TabIndex = 12;
            // 
            // btnMakeStudentList
            // 
            this.btnMakeStudentList.Location = new System.Drawing.Point(12, 129);
            this.btnMakeStudentList.Name = "btnMakeStudentList";
            this.btnMakeStudentList.Size = new System.Drawing.Size(75, 52);
            this.btnMakeStudentList.TabIndex = 13;
            this.btnMakeStudentList.Text = "Make Student List";
            this.btnMakeStudentList.UseVisualStyleBackColor = true;
            this.btnMakeStudentList.Click += new System.EventHandler(this.btnMakeStudentList_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 277);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(868, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 299);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnMakeStudentList);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.lblAreaCalc);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnGetStudent);
            this.Controls.Add(this.btnMakeStudent);
            this.Name = "frmStudent";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.frmStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMakeStudent;
        private System.Windows.Forms.Button btnGetStudent;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblAreaCalc;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Button btnMakeStudentList;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
    }
}