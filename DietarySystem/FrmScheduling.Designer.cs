﻿namespace DietarySystem
{
    partial class FrmScheduling
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.labellersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlCreate = new System.Windows.Forms.Panel();
            this.lblCurrentBook = new System.Windows.Forms.Label();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTimmings = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.pnlCancel = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblCancelDescription = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnlCreate.SuspendLayout();
            this.pnlCancel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem,
            this.accountToolStripMenuItem1,
            this.logoutToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1374, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createBookingToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.cancelToolStripMenuItem});
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(115, 36);
            this.accountToolStripMenuItem.Text = "Booking";
            // 
            // createBookingToolStripMenuItem
            // 
            this.createBookingToolStripMenuItem.Name = "createBookingToolStripMenuItem";
            this.createBookingToolStripMenuItem.Size = new System.Drawing.Size(191, 38);
            this.createBookingToolStripMenuItem.Text = "Create";
            this.createBookingToolStripMenuItem.Click += new System.EventHandler(this.createBookingToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(191, 38);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(191, 38);
            this.cancelToolStripMenuItem.Text = "Cancel";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // accountToolStripMenuItem1
            // 
            this.accountToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labellersToolStripMenuItem,
            this.createUserToolStripMenuItem});
            this.accountToolStripMenuItem1.Name = "accountToolStripMenuItem1";
            this.accountToolStripMenuItem1.Size = new System.Drawing.Size(97, 36);
            this.accountToolStripMenuItem1.Text = "Admin";
            // 
            // labellersToolStripMenuItem
            // 
            this.labellersToolStripMenuItem.Name = "labellersToolStripMenuItem";
            this.labellersToolStripMenuItem.Size = new System.Drawing.Size(211, 38);
            this.labellersToolStripMenuItem.Text = "Labellers";
            this.labellersToolStripMenuItem.Click += new System.EventHandler(this.labellersToolStripMenuItem_Click);
            // 
            // createUserToolStripMenuItem
            // 
            this.createUserToolStripMenuItem.Name = "createUserToolStripMenuItem";
            this.createUserToolStripMenuItem.Size = new System.Drawing.Size(211, 38);
            this.createUserToolStripMenuItem.Text = "Add User";
            this.createUserToolStripMenuItem.Click += new System.EventHandler(this.createUserToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem1
            // 
            this.logoutToolStripMenuItem1.Name = "logoutToolStripMenuItem1";
            this.logoutToolStripMenuItem1.Size = new System.Drawing.Size(102, 36);
            this.logoutToolStripMenuItem1.Text = "Logout";
            this.logoutToolStripMenuItem1.Click += new System.EventHandler(this.logoutToolStripMenuItem1_Click);
            // 
            // pnlCreate
            // 
            this.pnlCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCreate.AutoSize = true;
            this.pnlCreate.Controls.Add(this.lblCurrentBook);
            this.pnlCreate.Controls.Add(this.checkBox7);
            this.pnlCreate.Controls.Add(this.checkBox6);
            this.pnlCreate.Controls.Add(this.textBox1);
            this.pnlCreate.Controls.Add(this.btnSubmit);
            this.pnlCreate.Controls.Add(this.label2);
            this.pnlCreate.Controls.Add(this.checkBox5);
            this.pnlCreate.Controls.Add(this.checkBox4);
            this.pnlCreate.Controls.Add(this.checkBox3);
            this.pnlCreate.Controls.Add(this.checkBox2);
            this.pnlCreate.Controls.Add(this.checkBox1);
            this.pnlCreate.Controls.Add(this.label1);
            this.pnlCreate.Controls.Add(this.lblTimmings);
            this.pnlCreate.Controls.Add(this.checkedListBox1);
            this.pnlCreate.Location = new System.Drawing.Point(0, 43);
            this.pnlCreate.Name = "pnlCreate";
            this.pnlCreate.Size = new System.Drawing.Size(1386, 955);
            this.pnlCreate.TabIndex = 11;
            // 
            // lblCurrentBook
            // 
            this.lblCurrentBook.AutoSize = true;
            this.lblCurrentBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentBook.Location = new System.Drawing.Point(755, 80);
            this.lblCurrentBook.Name = "lblCurrentBook";
            this.lblCurrentBook.Size = new System.Drawing.Size(399, 138);
            this.lblCurrentBook.TabIndex = 18;
            this.lblCurrentBook.Text = "Currently booked on\r\n24 November 18\r\n2 : 00 PM\r\n";
            // 
            // checkBox7
            // 
            this.checkBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(43, 813);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(749, 29);
            this.checkBox7.TabIndex = 12;
            this.checkBox7.Text = "Do you agree to the terms and conditions of our privacy policy(hyperlink)?";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(43, 766);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(736, 29);
            this.checkBox6.TabIndex = 11;
            this.checkBox6.Text = "Would you like to recieve notifications like reminder of your booking etc?";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Location = new System.Drawing.Point(43, 627);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(557, 105);
            this.textBox1.TabIndex = 9;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSubmit.Location = new System.Drawing.Point(43, 862);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(115, 49);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 587);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Other";
            // 
            // checkBox5
            // 
            this.checkBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(43, 427);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(106, 29);
            this.checkBox5.TabIndex = 7;
            this.checkBox5.Text = "Vegan";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(43, 462);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(157, 29);
            this.checkBox4.TabIndex = 6;
            this.checkBox4.Text = "Gluten Free";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(43, 497);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(97, 29);
            this.checkBox3.TabIndex = 5;
            this.checkBox3.Text = "Other";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(43, 532);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(95, 29);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "None";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(43, 392);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(148, 29);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Vegetarian";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dietary Restrictions (If Any)";
            // 
            // lblTimmings
            // 
            this.lblTimmings.AutoSize = true;
            this.lblTimmings.Location = new System.Drawing.Point(38, 33);
            this.lblTimmings.Name = "lblTimmings";
            this.lblTimmings.Size = new System.Drawing.Size(188, 25);
            this.lblTimmings.TabIndex = 1;
            this.lblTimmings.Text = "Booking Timmings";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "16 November 2018 - 10:30 am",
            "16 November 2018 - 11:00 am",
            "16 November 2018 - 12:00 pm",
            "16 November 2018 - 01:00 pm",
            "16 November 2018 - 02:00 pm",
            "17 November 2018 - 10:30 am",
            "17 November 2018 - 11:00 am",
            "18 November 2018 - 12:00 pm",
            "18 November 2018 - 01:00 pm",
            "18 November 2018 - 02:00 pm"});
            this.checkedListBox1.Location = new System.Drawing.Point(43, 80);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(5);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(558, 238);
            this.checkedListBox1.TabIndex = 0;
            // 
            // pnlCancel
            // 
            this.pnlCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCancel.Controls.Add(this.btnCancel);
            this.pnlCancel.Controls.Add(this.lblCancelDescription);
            this.pnlCancel.Location = new System.Drawing.Point(0, 40);
            this.pnlCancel.Name = "pnlCancel";
            this.pnlCancel.Size = new System.Drawing.Size(1374, 955);
            this.pnlCancel.TabIndex = 12;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Location = new System.Drawing.Point(43, 804);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(194, 46);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel Booking";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblCancelDescription
            // 
            this.lblCancelDescription.AutoSize = true;
            this.lblCancelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelDescription.Location = new System.Drawing.Point(27, 80);
            this.lblCancelDescription.Name = "lblCancelDescription";
            this.lblCancelDescription.Size = new System.Drawing.Size(399, 138);
            this.lblCancelDescription.TabIndex = 17;
            this.lblCancelDescription.Text = "Currently booked on\r\n24 November 18\r\n2 : 00 PM\r\n";
            // 
            // FrmScheduling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1374, 994);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlCreate);
            this.Controls.Add(this.pnlCancel);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmScheduling";
            this.Text = "FrmScheduling";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlCreate.ResumeLayout(false);
            this.pnlCreate.PerformLayout();
            this.pnlCancel.ResumeLayout(false);
            this.pnlCancel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem1;
        private System.Windows.Forms.Panel pnlCreate;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTimmings;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Panel pnlCancel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblCancelDescription;
        private System.Windows.Forms.Label lblCurrentBook;
        private System.Windows.Forms.ToolStripMenuItem labellersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem1;
    }
}