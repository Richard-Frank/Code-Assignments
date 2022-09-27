namespace LunchOrder.UI
{
    partial class frmLunchOrder
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
            this.rdbHamburger = new System.Windows.Forms.RadioButton();
            this.rdbPizza = new System.Windows.Forms.RadioButton();
            this.rdbSalad = new System.Windows.Forms.RadioButton();
            this.grpMainCourse = new System.Windows.Forms.GroupBox();
            this.grpAddons = new System.Windows.Forms.GroupBox();
            this.chkAddon3 = new System.Windows.Forms.CheckBox();
            this.chkAddon2 = new System.Windows.Forms.CheckBox();
            this.chkAddon1 = new System.Windows.Forms.CheckBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.grpOrderTotal = new System.Windows.Forms.GroupBox();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpMainCourse.SuspendLayout();
            this.grpAddons.SuspendLayout();
            this.grpOrderTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbHamburger
            // 
            this.rdbHamburger.AutoSize = true;
            this.rdbHamburger.Location = new System.Drawing.Point(6, 28);
            this.rdbHamburger.Name = "rdbHamburger";
            this.rdbHamburger.Size = new System.Drawing.Size(113, 17);
            this.rdbHamburger.TabIndex = 0;
            this.rdbHamburger.Text = "Hamburger - $6.95";
            this.rdbHamburger.UseVisualStyleBackColor = true;
            this.rdbHamburger.CheckedChanged += new System.EventHandler(this.rdbHamburger_CheckedChanged);
            // 
            // rdbPizza
            // 
            this.rdbPizza.AutoSize = true;
            this.rdbPizza.Location = new System.Drawing.Point(6, 66);
            this.rdbPizza.Name = "rdbPizza";
            this.rdbPizza.Size = new System.Drawing.Size(86, 17);
            this.rdbPizza.TabIndex = 1;
            this.rdbPizza.Text = "Pizza - $5.95";
            this.rdbPizza.UseVisualStyleBackColor = true;
            this.rdbPizza.CheckedChanged += new System.EventHandler(this.rdbPizza_CheckedChanged);
            // 
            // rdbSalad
            // 
            this.rdbSalad.AutoSize = true;
            this.rdbSalad.Location = new System.Drawing.Point(6, 109);
            this.rdbSalad.Name = "rdbSalad";
            this.rdbSalad.Size = new System.Drawing.Size(88, 17);
            this.rdbSalad.TabIndex = 2;
            this.rdbSalad.Text = "Salad - $4.95";
            this.rdbSalad.UseVisualStyleBackColor = true;
            this.rdbSalad.CheckedChanged += new System.EventHandler(this.rdbSalad_CheckedChanged);
            // 
            // grpMainCourse
            // 
            this.grpMainCourse.Controls.Add(this.rdbHamburger);
            this.grpMainCourse.Controls.Add(this.rdbSalad);
            this.grpMainCourse.Controls.Add(this.rdbPizza);
            this.grpMainCourse.Location = new System.Drawing.Point(12, 12);
            this.grpMainCourse.Name = "grpMainCourse";
            this.grpMainCourse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grpMainCourse.Size = new System.Drawing.Size(124, 133);
            this.grpMainCourse.TabIndex = 8;
            this.grpMainCourse.TabStop = false;
            this.grpMainCourse.Text = "Main Corse";
            // 
            // grpAddons
            // 
            this.grpAddons.Controls.Add(this.chkAddon3);
            this.grpAddons.Controls.Add(this.chkAddon2);
            this.grpAddons.Controls.Add(this.chkAddon1);
            this.grpAddons.Location = new System.Drawing.Point(142, 12);
            this.grpAddons.Name = "grpAddons";
            this.grpAddons.Size = new System.Drawing.Size(196, 133);
            this.grpAddons.TabIndex = 9;
            this.grpAddons.TabStop = false;
            this.grpAddons.Text = "Add-on items (Optional)";
            // 
            // chkAddon3
            // 
            this.chkAddon3.AutoSize = true;
            this.chkAddon3.Location = new System.Drawing.Point(6, 109);
            this.chkAddon3.Name = "chkAddon3";
            this.chkAddon3.Size = new System.Drawing.Size(15, 14);
            this.chkAddon3.TabIndex = 6;
            this.chkAddon3.UseVisualStyleBackColor = true;
            this.chkAddon3.Visible = false;
            this.chkAddon3.CheckedChanged += new System.EventHandler(this.chkAddon3_CheckedChanged);
            // 
            // chkAddon2
            // 
            this.chkAddon2.AutoSize = true;
            this.chkAddon2.Location = new System.Drawing.Point(6, 67);
            this.chkAddon2.Name = "chkAddon2";
            this.chkAddon2.Size = new System.Drawing.Size(15, 14);
            this.chkAddon2.TabIndex = 5;
            this.chkAddon2.UseVisualStyleBackColor = true;
            this.chkAddon2.Visible = false;
            this.chkAddon2.CheckedChanged += new System.EventHandler(this.chkAddon2_CheckedChanged);
            // 
            // chkAddon1
            // 
            this.chkAddon1.AutoSize = true;
            this.chkAddon1.Location = new System.Drawing.Point(6, 29);
            this.chkAddon1.Name = "chkAddon1";
            this.chkAddon1.Size = new System.Drawing.Size(15, 14);
            this.chkAddon1.TabIndex = 4;
            this.chkAddon1.UseVisualStyleBackColor = true;
            this.chkAddon1.Visible = false;
            this.chkAddon1.CheckedChanged += new System.EventHandler(this.chkAddon1_CheckedChanged);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(263, 288);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(263, 151);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(75, 93);
            this.btnPlaceOrder.TabIndex = 7;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // grpOrderTotal
            // 
            this.grpOrderTotal.Controls.Add(this.lblOrderTotal);
            this.grpOrderTotal.Controls.Add(this.lblTax);
            this.grpOrderTotal.Controls.Add(this.lblSubTotal);
            this.grpOrderTotal.Controls.Add(this.label3);
            this.grpOrderTotal.Controls.Add(this.label2);
            this.grpOrderTotal.Controls.Add(this.label1);
            this.grpOrderTotal.Location = new System.Drawing.Point(12, 151);
            this.grpOrderTotal.Name = "grpOrderTotal";
            this.grpOrderTotal.Size = new System.Drawing.Size(226, 160);
            this.grpOrderTotal.TabIndex = 10;
            this.grpOrderTotal.TabStop = false;
            this.grpOrderTotal.Text = "Order Total";
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOrderTotal.Location = new System.Drawing.Point(78, 126);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblOrderTotal.Size = new System.Drawing.Size(138, 16);
            this.lblOrderTotal.TabIndex = 13;
            // 
            // lblTax
            // 
            this.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTax.Location = new System.Drawing.Point(78, 77);
            this.lblTax.Name = "lblTax";
            this.lblTax.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblTax.Size = new System.Drawing.Size(138, 16);
            this.lblTax.TabIndex = 12;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSubTotal.Location = new System.Drawing.Point(78, 25);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSubTotal.Size = new System.Drawing.Size(138, 16);
            this.lblSubTotal.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Order Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tax (7.75%):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Subtotal:";
            // 
            // frmLunchOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 323);
            this.Controls.Add(this.grpOrderTotal);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpAddons);
            this.Controls.Add(this.grpMainCourse);
            this.Name = "frmLunchOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Place you Lunch Order.";
            this.Load += new System.EventHandler(this.frmLunchOrder_Load);
            this.grpMainCourse.ResumeLayout(false);
            this.grpMainCourse.PerformLayout();
            this.grpAddons.ResumeLayout(false);
            this.grpAddons.PerformLayout();
            this.grpOrderTotal.ResumeLayout(false);
            this.grpOrderTotal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbHamburger;
        private System.Windows.Forms.RadioButton rdbPizza;
        private System.Windows.Forms.RadioButton rdbSalad;
        private System.Windows.Forms.GroupBox grpMainCourse;
        private System.Windows.Forms.GroupBox grpAddons;
        private System.Windows.Forms.CheckBox chkAddon3;
        private System.Windows.Forms.CheckBox chkAddon2;
        private System.Windows.Forms.CheckBox chkAddon1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.GroupBox grpOrderTotal;
        private System.Windows.Forms.Label lblOrderTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

