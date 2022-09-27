namespace YoutubeTimer
{
    partial class frmYoutubeTimer
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
            this.components = new System.ComponentModel.Container();
            this.btnStartClock = new System.Windows.Forms.Button();
            this.btnStopClock = new System.Windows.Forms.Button();
            this.btnSetTime = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSaveTime = new System.Windows.Forms.Button();
            this.lblTimerBackround = new System.Windows.Forms.Label();
            this.btnSetRecordingHelp = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtSetTime = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.dgvTimeList = new System.Windows.Forms.DataGridView();
            this.tmrTimer = new System.Windows.Forms.Timer(this.components);
            this.tmrTotalTime = new System.Windows.Forms.Timer(this.components);
            this.lblTimeSet = new System.Windows.Forms.Label();
            this.btnSetName = new System.Windows.Forms.Button();
            this.txtSetName = new System.Windows.Forms.TextBox();
            this.lblNameSet = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStartClock
            // 
            this.btnStartClock.Location = new System.Drawing.Point(13, 12);
            this.btnStartClock.Name = "btnStartClock";
            this.btnStartClock.Size = new System.Drawing.Size(75, 54);
            this.btnStartClock.TabIndex = 0;
            this.btnStartClock.Text = "Start Clock";
            this.btnStartClock.UseVisualStyleBackColor = true;
            this.btnStartClock.Click += new System.EventHandler(this.btnStartClock_Click);
            // 
            // btnStopClock
            // 
            this.btnStopClock.Location = new System.Drawing.Point(13, 72);
            this.btnStopClock.Name = "btnStopClock";
            this.btnStopClock.Size = new System.Drawing.Size(75, 52);
            this.btnStopClock.TabIndex = 1;
            this.btnStopClock.Text = "Stop Clock";
            this.btnStopClock.UseVisualStyleBackColor = true;
            this.btnStopClock.Click += new System.EventHandler(this.btnStopClock_Click);
            // 
            // btnSetTime
            // 
            this.btnSetTime.Location = new System.Drawing.Point(12, 315);
            this.btnSetTime.Name = "btnSetTime";
            this.btnSetTime.Size = new System.Drawing.Size(121, 23);
            this.btnSetTime.TabIndex = 2;
            this.btnSetTime.Text = "Set Recording Time";
            this.btnSetTime.UseVisualStyleBackColor = true;
            this.btnSetTime.Click += new System.EventHandler(this.btnSetTime_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(435, 344);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSaveTime
            // 
            this.btnSaveTime.Location = new System.Drawing.Point(13, 130);
            this.btnSaveTime.Name = "btnSaveTime";
            this.btnSaveTime.Size = new System.Drawing.Size(75, 35);
            this.btnSaveTime.TabIndex = 4;
            this.btnSaveTime.Text = "Save Time List";
            this.btnSaveTime.UseVisualStyleBackColor = true;
            // 
            // lblTimerBackround
            // 
            this.lblTimerBackround.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTimerBackround.Location = new System.Drawing.Point(93, 12);
            this.lblTimerBackround.Name = "lblTimerBackround";
            this.lblTimerBackround.Size = new System.Drawing.Size(366, 134);
            this.lblTimerBackround.TabIndex = 5;
            // 
            // btnSetRecordingHelp
            // 
            this.btnSetRecordingHelp.Location = new System.Drawing.Point(139, 315);
            this.btnSetRecordingHelp.Name = "btnSetRecordingHelp";
            this.btnSetRecordingHelp.Size = new System.Drawing.Size(27, 23);
            this.btnSetRecordingHelp.TabIndex = 6;
            this.btnSetRecordingHelp.Text = "?";
            this.btnSetRecordingHelp.UseVisualStyleBackColor = true;
            this.btnSetRecordingHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 377);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(519, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // txtSetTime
            // 
            this.txtSetTime.Location = new System.Drawing.Point(13, 344);
            this.txtSetTime.Name = "txtSetTime";
            this.txtSetTime.Size = new System.Drawing.Size(152, 20);
            this.txtSetTime.TabIndex = 8;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(104, 49);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(284, 73);
            this.lblTime.TabIndex = 10;
            this.lblTime.Text = "00:00:00";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(437, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 51);
            this.label1.TabIndex = 11;
            this.label1.Text = "Total Time";
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.AutoSize = true;
            this.lblTotalTime.Location = new System.Drawing.Point(446, 181);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(49, 13);
            this.lblTotalTime.TabIndex = 12;
            this.lblTotalTime.Text = "00:00:00";
            // 
            // dgvTimeList
            // 
            this.dgvTimeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimeList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTimeList.Location = new System.Drawing.Point(188, 153);
            this.dgvTimeList.Name = "dgvTimeList";
            this.dgvTimeList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTimeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTimeList.Size = new System.Drawing.Size(241, 218);
            this.dgvTimeList.TabIndex = 13;
            this.dgvTimeList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTimeList_CellContentClick);
            // 
            // tmrTimer
            // 
            this.tmrTimer.Interval = 1;
            this.tmrTimer.Tick += new System.EventHandler(this.tmrTimer_Tick);
            // 
            // tmrTotalTime
            // 
            this.tmrTotalTime.Interval = 60000;
            this.tmrTotalTime.Tick += new System.EventHandler(this.tmrTotalTime_Tick);
            // 
            // lblTimeSet
            // 
            this.lblTimeSet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTimeSet.Location = new System.Drawing.Point(13, 282);
            this.lblTimeSet.Name = "lblTimeSet";
            this.lblTimeSet.Size = new System.Drawing.Size(152, 30);
            this.lblTimeSet.TabIndex = 14;
            this.lblTimeSet.Text = "Time has been not been set!";
            // 
            // btnSetName
            // 
            this.btnSetName.Location = new System.Drawing.Point(13, 226);
            this.btnSetName.Name = "btnSetName";
            this.btnSetName.Size = new System.Drawing.Size(120, 23);
            this.btnSetName.TabIndex = 15;
            this.btnSetName.Text = "Set Recording Name";
            this.btnSetName.UseVisualStyleBackColor = true;
            this.btnSetName.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSetName
            // 
            this.txtSetName.Location = new System.Drawing.Point(12, 255);
            this.txtSetName.Name = "txtSetName";
            this.txtSetName.Size = new System.Drawing.Size(152, 20);
            this.txtSetName.TabIndex = 16;
            // 
            // lblNameSet
            // 
            this.lblNameSet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNameSet.Location = new System.Drawing.Point(12, 193);
            this.lblNameSet.Name = "lblNameSet";
            this.lblNameSet.Size = new System.Drawing.Size(152, 30);
            this.lblNameSet.TabIndex = 17;
            this.lblNameSet.Text = "A Name has not been set.";
            // 
            // frmYoutubeTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 399);
            this.Controls.Add(this.lblNameSet);
            this.Controls.Add(this.txtSetName);
            this.Controls.Add(this.btnSetName);
            this.Controls.Add(this.lblTimeSet);
            this.Controls.Add(this.dgvTimeList);
            this.Controls.Add(this.lblTotalTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.txtSetTime);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnSetRecordingHelp);
            this.Controls.Add(this.lblTimerBackround);
            this.Controls.Add(this.btnSaveTime);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSetTime);
            this.Controls.Add(this.btnStopClock);
            this.Controls.Add(this.btnStartClock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmYoutubeTimer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Youtube Recording Timer Ver 1.0";
            this.Load += new System.EventHandler(this.frmYoutubeTimer_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartClock;
        private System.Windows.Forms.Button btnStopClock;
        private System.Windows.Forms.Button btnSetTime;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSaveTime;
        private System.Windows.Forms.Label lblTimerBackround;
        private System.Windows.Forms.Button btnSetRecordingHelp;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.TextBox txtSetTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalTime;
        private System.Windows.Forms.DataGridView dgvTimeList;
        private System.Windows.Forms.Timer tmrTimer;
        private System.Windows.Forms.Timer tmrTotalTime;
        private System.Windows.Forms.Label lblTimeSet;
        private System.Windows.Forms.Button btnSetName;
        private System.Windows.Forms.TextBox txtSetName;
        private System.Windows.Forms.Label lblNameSet;
    }
}

