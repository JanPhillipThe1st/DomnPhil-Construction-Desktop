﻿
namespace DomnPhil_Construction
{
    partial class Add_Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Employee));
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbEmployeeDetails = new System.Windows.Forms.GroupBox();
            this.cbRateCalculationType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbShopRate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbOperationalRate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSite = new System.Windows.Forms.TextBox();
            this.tbControlNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDesignation = new System.Windows.Forms.TextBox();
            this.tbPosition = new System.Windows.Forms.TextBox();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.bannerPanel = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.gbEmployeeDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Location = new System.Drawing.Point(425, 284);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(133, 32);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Add Employee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "First Name";
            // 
            // gbEmployeeDetails
            // 
            this.gbEmployeeDetails.Controls.Add(this.cbRateCalculationType);
            this.gbEmployeeDetails.Controls.Add(this.btnSave);
            this.gbEmployeeDetails.Controls.Add(this.label10);
            this.gbEmployeeDetails.Controls.Add(this.label13);
            this.gbEmployeeDetails.Controls.Add(this.label12);
            this.gbEmployeeDetails.Controls.Add(this.label9);
            this.gbEmployeeDetails.Controls.Add(this.label8);
            this.gbEmployeeDetails.Controls.Add(this.label7);
            this.gbEmployeeDetails.Controls.Add(this.label11);
            this.gbEmployeeDetails.Controls.Add(this.label6);
            this.gbEmployeeDetails.Controls.Add(this.tbShopRate);
            this.gbEmployeeDetails.Controls.Add(this.label4);
            this.gbEmployeeDetails.Controls.Add(this.tbOperationalRate);
            this.gbEmployeeDetails.Controls.Add(this.label1);
            this.gbEmployeeDetails.Controls.Add(this.tbSite);
            this.gbEmployeeDetails.Controls.Add(this.tbControlNumber);
            this.gbEmployeeDetails.Controls.Add(this.label5);
            this.gbEmployeeDetails.Controls.Add(this.tbDesignation);
            this.gbEmployeeDetails.Controls.Add(this.label3);
            this.gbEmployeeDetails.Controls.Add(this.tbPosition);
            this.gbEmployeeDetails.Controls.Add(this.tbFullName);
            this.gbEmployeeDetails.Controls.Add(this.tbLastName);
            this.gbEmployeeDetails.Controls.Add(this.tbFirstName);
            this.gbEmployeeDetails.Location = new System.Drawing.Point(17, 114);
            this.gbEmployeeDetails.Name = "gbEmployeeDetails";
            this.gbEmployeeDetails.Size = new System.Drawing.Size(576, 337);
            this.gbEmployeeDetails.TabIndex = 5;
            this.gbEmployeeDetails.TabStop = false;
            // 
            // cbRateCalculationType
            // 
            this.cbRateCalculationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRateCalculationType.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRateCalculationType.FormattingEnabled = true;
            this.cbRateCalculationType.Items.AddRange(new object[] {
            "flat",
            "variable"});
            this.cbRateCalculationType.Location = new System.Drawing.Point(281, 247);
            this.cbRateCalculationType.Name = "cbRateCalculationType";
            this.cbRateCalculationType.Size = new System.Drawing.Size(277, 31);
            this.cbRateCalculationType.TabIndex = 6;
            this.cbRateCalculationType.SelectedIndexChanged += new System.EventHandler(this.cbRateCalculationType_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(281, 223);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 23);
            this.label10.TabIndex = 4;
            this.label10.Text = "Rate Calculation Type";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Poppins", 8F);
            this.label13.Location = new System.Drawing.Point(539, 125);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(19, 19);
            this.label13.TabIndex = 4;
            this.label13.Text = "**";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Poppins", 8F);
            this.label12.Location = new System.Drawing.Point(539, 176);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 19);
            this.label12.TabIndex = 4;
            this.label12.Text = "**";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(281, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 23);
            this.label9.TabIndex = 4;
            this.label9.Text = "Shop rate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(281, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 23);
            this.label8.TabIndex = 4;
            this.label8.Text = "Operational rate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(281, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 23);
            this.label7.TabIndex = 4;
            this.label7.Text = "Site";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 23);
            this.label11.TabIndex = 4;
            this.label11.Text = "Control Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(281, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Designation";
            // 
            // tbShopRate
            // 
            this.tbShopRate.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbShopRate.Location = new System.Drawing.Point(281, 196);
            this.tbShopRate.Margin = new System.Windows.Forms.Padding(4);
            this.tbShopRate.Name = "tbShopRate";
            this.tbShopRate.Size = new System.Drawing.Size(277, 27);
            this.tbShopRate.TabIndex = 5;
            this.tbShopRate.TextChanged += new System.EventHandler(this.tbShopRate_TextChanged);
            this.tbShopRate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbShopRate_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Position";
            // 
            // tbOperationalRate
            // 
            this.tbOperationalRate.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOperationalRate.Location = new System.Drawing.Point(281, 145);
            this.tbOperationalRate.Margin = new System.Windows.Forms.Padding(4);
            this.tbOperationalRate.Name = "tbOperationalRate";
            this.tbOperationalRate.Size = new System.Drawing.Size(277, 27);
            this.tbOperationalRate.TabIndex = 5;
            this.tbOperationalRate.TextChanged += new System.EventHandler(this.tbOperationalRate_TextChanged);
            this.tbOperationalRate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbOperationalRate_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Full Name";
            // 
            // tbSite
            // 
            this.tbSite.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbSite.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSite.Location = new System.Drawing.Point(281, 94);
            this.tbSite.Margin = new System.Windows.Forms.Padding(4);
            this.tbSite.Name = "tbSite";
            this.tbSite.Size = new System.Drawing.Size(277, 27);
            this.tbSite.TabIndex = 5;
            // 
            // tbControlNumber
            // 
            this.tbControlNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbControlNumber.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbControlNumber.Location = new System.Drawing.Point(6, 43);
            this.tbControlNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tbControlNumber.Name = "tbControlNumber";
            this.tbControlNumber.Size = new System.Drawing.Size(230, 27);
            this.tbControlNumber.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Last Name";
            // 
            // tbDesignation
            // 
            this.tbDesignation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbDesignation.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDesignation.Location = new System.Drawing.Point(281, 43);
            this.tbDesignation.Margin = new System.Windows.Forms.Padding(4);
            this.tbDesignation.Name = "tbDesignation";
            this.tbDesignation.Size = new System.Drawing.Size(277, 27);
            this.tbDesignation.TabIndex = 5;
            // 
            // tbPosition
            // 
            this.tbPosition.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbPosition.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPosition.Location = new System.Drawing.Point(6, 247);
            this.tbPosition.Margin = new System.Windows.Forms.Padding(4);
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Size = new System.Drawing.Size(230, 27);
            this.tbPosition.TabIndex = 5;
            // 
            // tbFullName
            // 
            this.tbFullName.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFullName.Location = new System.Drawing.Point(6, 196);
            this.tbFullName.Margin = new System.Windows.Forms.Padding(4);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(230, 27);
            this.tbFullName.TabIndex = 5;
            this.tbFullName.TextChanged += new System.EventHandler(this.tbOperationalDays_TextChanged);
            // 
            // tbLastName
            // 
            this.tbLastName.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLastName.Location = new System.Drawing.Point(6, 145);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(4);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(230, 27);
            this.tbLastName.TabIndex = 5;
            this.tbLastName.TextChanged += new System.EventHandler(this.tbLastName_TextChanged);
            // 
            // tbFirstName
            // 
            this.tbFirstName.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirstName.Location = new System.Drawing.Point(6, 94);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(230, 27);
            this.tbFirstName.TabIndex = 5;
            this.tbFirstName.TextChanged += new System.EventHandler(this.tbLastName_TextChanged);
            // 
            // bannerPanel
            // 
            this.bannerPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bannerPanel.BackgroundImage")));
            this.bannerPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bannerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.bannerPanel.Location = new System.Drawing.Point(0, 0);
            this.bannerPanel.Margin = new System.Windows.Forms.Padding(4);
            this.bannerPanel.Name = "bannerPanel";
            this.bannerPanel.Size = new System.Drawing.Size(610, 81);
            this.bannerPanel.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Poppins", 8F);
            this.label14.Location = new System.Drawing.Point(282, 94);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(311, 19);
            this.label14.TabIndex = 4;
            this.label14.Text = "**: You can type expressions to automatically calculate";
            // 
            // Add_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(610, 476);
            this.Controls.Add(this.gbEmployeeDetails);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bannerPanel);
            this.Controls.Add(this.label14);
            this.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Add_Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Attendance";
            this.Load += new System.EventHandler(this.Employees_Load);
            this.gbEmployeeDetails.ResumeLayout(false);
            this.gbEmployeeDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel bannerPanel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbEmployeeDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbPosition;
        private System.Windows.Forms.TextBox tbFullName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDesignation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbSite;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbShopRate;
        private System.Windows.Forms.TextBox tbOperationalRate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbRateCalculationType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbControlNumber;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}

