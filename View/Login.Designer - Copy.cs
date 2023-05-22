
namespace DomnPhil_Construction
{
    partial class Edit_Attendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_Attendance));
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbEmployeeDetails = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbUndertime = new System.Windows.Forms.TextBox();
            this.tbOverimeHours = new System.Windows.Forms.TextBox();
            this.tbOperationalDays = new System.Windows.Forms.TextBox();
            this.tbAbsences = new System.Windows.Forms.TextBox();
            this.tbNonOperationalDays = new System.Windows.Forms.TextBox();
            this.btnDeductibles = new System.Windows.Forms.Button();
            this.bannerPanel = new System.Windows.Forms.Panel();
            this.gbEmployeeDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSave.Font = new System.Drawing.Font("Poppins", 10F);
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Location = new System.Drawing.Point(323, 303);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 32);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Medium", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Edit Employee Attendance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 10F);
            this.label3.Location = new System.Drawing.Point(28, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Non-operational days";
            // 
            // gbEmployeeDetails
            // 
            this.gbEmployeeDetails.Controls.Add(this.btnSave);
            this.gbEmployeeDetails.Controls.Add(this.label6);
            this.gbEmployeeDetails.Controls.Add(this.label4);
            this.gbEmployeeDetails.Controls.Add(this.label1);
            this.gbEmployeeDetails.Controls.Add(this.label5);
            this.gbEmployeeDetails.Controls.Add(this.tbUndertime);
            this.gbEmployeeDetails.Controls.Add(this.label3);
            this.gbEmployeeDetails.Controls.Add(this.tbOverimeHours);
            this.gbEmployeeDetails.Controls.Add(this.tbOperationalDays);
            this.gbEmployeeDetails.Controls.Add(this.tbAbsences);
            this.gbEmployeeDetails.Controls.Add(this.tbNonOperationalDays);
            this.gbEmployeeDetails.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEmployeeDetails.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbEmployeeDetails.Location = new System.Drawing.Point(17, 117);
            this.gbEmployeeDetails.Name = "gbEmployeeDetails";
            this.gbEmployeeDetails.Size = new System.Drawing.Size(459, 362);
            this.gbEmployeeDetails.TabIndex = 5;
            this.gbEmployeeDetails.TabStop = false;
            this.gbEmployeeDetails.Text = "Employee Attendance";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 10F);
            this.label6.Location = new System.Drawing.Point(28, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Undertime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 10F);
            this.label4.Location = new System.Drawing.Point(28, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Overtime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 10F);
            this.label1.Location = new System.Drawing.Point(28, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Operational Days";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 10F);
            this.label5.Location = new System.Drawing.Point(28, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Days Absent";
            // 
            // tbUndertime
            // 
            this.tbUndertime.Font = new System.Drawing.Font("Poppins", 10F);
            this.tbUndertime.Location = new System.Drawing.Point(33, 269);
            this.tbUndertime.Margin = new System.Windows.Forms.Padding(4);
            this.tbUndertime.Name = "tbUndertime";
            this.tbUndertime.Size = new System.Drawing.Size(408, 27);
            this.tbUndertime.TabIndex = 5;
            // 
            // tbOverimeHours
            // 
            this.tbOverimeHours.Font = new System.Drawing.Font("Poppins", 10F);
            this.tbOverimeHours.Location = new System.Drawing.Point(33, 217);
            this.tbOverimeHours.Margin = new System.Windows.Forms.Padding(4);
            this.tbOverimeHours.Name = "tbOverimeHours";
            this.tbOverimeHours.Size = new System.Drawing.Size(408, 27);
            this.tbOverimeHours.TabIndex = 5;
            // 
            // tbOperationalDays
            // 
            this.tbOperationalDays.Font = new System.Drawing.Font("Poppins", 10F);
            this.tbOperationalDays.Location = new System.Drawing.Point(33, 165);
            this.tbOperationalDays.Margin = new System.Windows.Forms.Padding(4);
            this.tbOperationalDays.Name = "tbOperationalDays";
            this.tbOperationalDays.Size = new System.Drawing.Size(408, 27);
            this.tbOperationalDays.TabIndex = 5;
            this.tbOperationalDays.TextChanged += new System.EventHandler(this.tbOperationalDays_TextChanged);
            // 
            // tbAbsences
            // 
            this.tbAbsences.Font = new System.Drawing.Font("Poppins", 10F);
            this.tbAbsences.Location = new System.Drawing.Point(33, 113);
            this.tbAbsences.Margin = new System.Windows.Forms.Padding(4);
            this.tbAbsences.Name = "tbAbsences";
            this.tbAbsences.Size = new System.Drawing.Size(408, 27);
            this.tbAbsences.TabIndex = 5;
            this.tbAbsences.TextChanged += new System.EventHandler(this.tbAbsences_TextChanged);
            // 
            // tbNonOperationalDays
            // 
            this.tbNonOperationalDays.Font = new System.Drawing.Font("Poppins", 10F);
            this.tbNonOperationalDays.Location = new System.Drawing.Point(33, 61);
            this.tbNonOperationalDays.Margin = new System.Windows.Forms.Padding(4);
            this.tbNonOperationalDays.Name = "tbNonOperationalDays";
            this.tbNonOperationalDays.Size = new System.Drawing.Size(408, 27);
            this.tbNonOperationalDays.TabIndex = 5;
            this.tbNonOperationalDays.TextChanged += new System.EventHandler(this.tbNonOperationalDays_TextChanged);
            // 
            // btnDeductibles
            // 
            this.btnDeductibles.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeductibles.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeductibles.Location = new System.Drawing.Point(335, 82);
            this.btnDeductibles.Margin = new System.Windows.Forms.Padding(1);
            this.btnDeductibles.Name = "btnDeductibles";
            this.btnDeductibles.Size = new System.Drawing.Size(141, 32);
            this.btnDeductibles.TabIndex = 3;
            this.btnDeductibles.Text = "Deductibles";
            this.btnDeductibles.UseVisualStyleBackColor = true;
            this.btnDeductibles.Click += new System.EventHandler(this.btnDeductibles_Click);
            // 
            // bannerPanel
            // 
            this.bannerPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bannerPanel.BackgroundImage")));
            this.bannerPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bannerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.bannerPanel.Location = new System.Drawing.Point(0, 0);
            this.bannerPanel.Margin = new System.Windows.Forms.Padding(4);
            this.bannerPanel.Name = "bannerPanel";
            this.bannerPanel.Size = new System.Drawing.Size(492, 72);
            this.bannerPanel.TabIndex = 0;
            // 
            // Edit_Attendance
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(492, 498);
            this.Controls.Add(this.btnDeductibles);
            this.Controls.Add(this.gbEmployeeDetails);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bannerPanel);
            this.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Edit_Attendance";
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
        private System.Windows.Forms.TextBox tbNonOperationalDays;
        private System.Windows.Forms.TextBox tbOverimeHours;
        private System.Windows.Forms.TextBox tbOperationalDays;
        private System.Windows.Forms.TextBox tbAbsences;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDeductibles;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbUndertime;
    }
}

