
using System;

namespace DomnPhil_Construction
{
    partial class Deductibles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deductibles));
            this.bannerPanel = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbEmployeeDetails = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMonthEndCashAdvance = new System.Windows.Forms.TextBox();
            this.tbPhilHealth = new System.Windows.Forms.TextBox();
            this.tbPagIbig = new System.Windows.Forms.TextBox();
            this.tbLoan = new System.Windows.Forms.TextBox();
            this.tbSSS = new System.Windows.Forms.TextBox();
            this.tbCashAdvance = new System.Windows.Forms.TextBox();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbEmployeeDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // bannerPanel
            // 
            this.bannerPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bannerPanel.BackgroundImage")));
            this.bannerPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bannerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.bannerPanel.Location = new System.Drawing.Point(0, 0);
            this.bannerPanel.Margin = new System.Windows.Forms.Padding(4);
            this.bannerPanel.Name = "bannerPanel";
            this.bannerPanel.Size = new System.Drawing.Size(404, 67);
            this.bannerPanel.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Location = new System.Drawing.Point(213, 347);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 28);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Medium", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Deductibles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cash Advance";
            // 
            // gbEmployeeDetails
            // 
            this.gbEmployeeDetails.Controls.Add(this.btnSave);
            this.gbEmployeeDetails.Controls.Add(this.label7);
            this.gbEmployeeDetails.Controls.Add(this.label4);
            this.gbEmployeeDetails.Controls.Add(this.label1);
            this.gbEmployeeDetails.Controls.Add(this.label5);
            this.gbEmployeeDetails.Controls.Add(this.label6);
            this.gbEmployeeDetails.Controls.Add(this.tbMonthEndCashAdvance);
            this.gbEmployeeDetails.Controls.Add(this.label3);
            this.gbEmployeeDetails.Controls.Add(this.tbPhilHealth);
            this.gbEmployeeDetails.Controls.Add(this.tbPagIbig);
            this.gbEmployeeDetails.Controls.Add(this.tbLoan);
            this.gbEmployeeDetails.Controls.Add(this.tbSSS);
            this.gbEmployeeDetails.Controls.Add(this.tbCashAdvance);
            this.gbEmployeeDetails.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbEmployeeDetails.Location = new System.Drawing.Point(17, 110);
            this.gbEmployeeDetails.Name = "gbEmployeeDetails";
            this.gbEmployeeDetails.Size = new System.Drawing.Size(366, 396);
            this.gbEmployeeDetails.TabIndex = 5;
            this.gbEmployeeDetails.TabStop = false;
            this.gbEmployeeDetails.Text = "Employee Attendance";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 23);
            this.label7.TabIndex = 4;
            this.label7.Text = "Month End Cash Advance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "PhilHealth";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pag-ibig";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "SSS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Loan";
            // 
            // tbMonthEndCashAdvance
            // 
            this.tbMonthEndCashAdvance.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMonthEndCashAdvance.Location = new System.Drawing.Point(21, 313);
            this.tbMonthEndCashAdvance.Margin = new System.Windows.Forms.Padding(4);
            this.tbMonthEndCashAdvance.Name = "tbMonthEndCashAdvance";
            this.tbMonthEndCashAdvance.Size = new System.Drawing.Size(320, 27);
            this.tbMonthEndCashAdvance.TabIndex = 5;
            // 
            // tbPhilHealth
            // 
            this.tbPhilHealth.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhilHealth.Location = new System.Drawing.Point(21, 262);
            this.tbPhilHealth.Margin = new System.Windows.Forms.Padding(4);
            this.tbPhilHealth.Name = "tbPhilHealth";
            this.tbPhilHealth.Size = new System.Drawing.Size(320, 27);
            this.tbPhilHealth.TabIndex = 5;
            // 
            // tbPagIbig
            // 
            this.tbPagIbig.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPagIbig.Location = new System.Drawing.Point(21, 211);
            this.tbPagIbig.Margin = new System.Windows.Forms.Padding(4);
            this.tbPagIbig.Name = "tbPagIbig";
            this.tbPagIbig.Size = new System.Drawing.Size(320, 27);
            this.tbPagIbig.TabIndex = 5;
            this.tbPagIbig.TextChanged += new System.EventHandler(this.tbOperationalDays_TextChanged);
            // 
            // tbLoan
            // 
            this.tbLoan.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLoan.Location = new System.Drawing.Point(21, 109);
            this.tbLoan.Margin = new System.Windows.Forms.Padding(4);
            this.tbLoan.Name = "tbLoan";
            this.tbLoan.Size = new System.Drawing.Size(320, 27);
            this.tbLoan.TabIndex = 5;
            this.tbLoan.TextChanged += new System.EventHandler(this.tbNonOperationalDays_TextChanged);
            // 
            // tbSSS
            // 
            this.tbSSS.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSSS.Location = new System.Drawing.Point(21, 160);
            this.tbSSS.Margin = new System.Windows.Forms.Padding(4);
            this.tbSSS.Name = "tbSSS";
            this.tbSSS.Size = new System.Drawing.Size(320, 27);
            this.tbSSS.TabIndex = 5;
            this.tbSSS.TextChanged += new System.EventHandler(this.tbAbsences_TextChanged);
            // 
            // tbCashAdvance
            // 
            this.tbCashAdvance.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCashAdvance.Location = new System.Drawing.Point(21, 58);
            this.tbCashAdvance.Margin = new System.Windows.Forms.Padding(4);
            this.tbCashAdvance.Name = "tbCashAdvance";
            this.tbCashAdvance.Size = new System.Drawing.Size(320, 27);
            this.tbCashAdvance.TabIndex = 5;
            this.tbCashAdvance.TextChanged += new System.EventHandler(this.tbNonOperationalDays_TextChanged);
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("Poppins Medium", 11F, System.Drawing.FontStyle.Bold);
            this.lblEmployeeName.Location = new System.Drawing.Point(247, 81);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(100, 26);
            this.lblEmployeeName.TabIndex = 2;
            this.lblEmployeeName.Text = "Employee:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Deductibles
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(404, 528);
            this.Controls.Add(this.gbEmployeeDetails);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bannerPanel);
            this.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Deductibles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deductibles";
            this.Load += new System.EventHandler(this.Employees_Load);
            this.gbEmployeeDetails.ResumeLayout(false);
            this.gbEmployeeDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.TextBox tbCashAdvance;
        private System.Windows.Forms.TextBox tbPhilHealth;
        private System.Windows.Forms.TextBox tbPagIbig;
        private System.Windows.Forms.TextBox tbSSS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.TextBox tbLoan;

        private void tbNonOperationalDays_TextChanged(object sender, System.EventArgs e)
        {

            if (inputUtilities.isInteger(tbCashAdvance.Text))
            {
                employee.cash_advance = Convert.ToInt32(tbCashAdvance.Text);
            }
            else
            {
                tbCashAdvance.Clear();
            }
        }

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbMonthEndCashAdvance;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

