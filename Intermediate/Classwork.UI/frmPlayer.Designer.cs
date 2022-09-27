namespace Classwork.UI
{
    partial class frmPlayer
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
            this.btnMakePlayer = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.btnMakePlayers = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dvgPlayers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMakePlayer
            // 
            this.btnMakePlayer.Location = new System.Drawing.Point(12, 12);
            this.btnMakePlayer.Name = "btnMakePlayer";
            this.btnMakePlayer.Size = new System.Drawing.Size(119, 23);
            this.btnMakePlayer.TabIndex = 0;
            this.btnMakePlayer.Text = "Make Player";
            this.btnMakePlayer.UseVisualStyleBackColor = true;
            this.btnMakePlayer.Click += new System.EventHandler(this.btnMakePlayer_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 97);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 126);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(119, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // lstResults
            // 
            this.lstResults.FormattingEnabled = true;
            this.lstResults.Location = new System.Drawing.Point(152, 12);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(238, 225);
            this.lstResults.TabIndex = 4;
            // 
            // btnMakePlayers
            // 
            this.btnMakePlayers.Location = new System.Drawing.Point(12, 39);
            this.btnMakePlayers.Name = "btnMakePlayers";
            this.btnMakePlayers.Size = new System.Drawing.Size(119, 23);
            this.btnMakePlayers.TabIndex = 5;
            this.btnMakePlayers.Text = "Make Players";
            this.btnMakePlayers.UseVisualStyleBackColor = true;
            this.btnMakePlayers.Click += new System.EventHandler(this.btnMakePlayers_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 157);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(119, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 186);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(119, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // dvgPlayers
            // 
            this.dvgPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgPlayers.Location = new System.Drawing.Point(396, 12);
            this.dvgPlayers.Name = "dvgPlayers";
            this.dvgPlayers.Size = new System.Drawing.Size(307, 229);
            this.dvgPlayers.TabIndex = 8;
            // 
            // frmPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 253);
            this.Controls.Add(this.dvgPlayers);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnMakePlayers);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnMakePlayer);
            this.Name = "frmPlayer";
            this.Text = "Player Info";
            this.Load += new System.EventHandler(this.frmPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgPlayers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMakePlayer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox lstResults;
        private System.Windows.Forms.Button btnMakePlayers;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dvgPlayers;
    }
}