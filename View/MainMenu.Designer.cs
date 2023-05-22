
namespace DomnPhil_Construction.View
{
    partial class MainMenu
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
            this.panelBanner = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnAttendance = new System.Windows.Forms.Button();
            this.btnCashAdvanceLoan = new System.Windows.Forms.Button();
            this.btnEquipments = new System.Windows.Forms.Button();
            this.btnPurchaseOrders = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelBanner
            // 
            this.panelBanner.BackColor = System.Drawing.Color.White;
            this.panelBanner.BackgroundImage = global::DomnPhil_Construction.Properties.Resources._2x5_domnphil_construction___letter_head;
            this.panelBanner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBanner.Location = new System.Drawing.Point(0, 0);
            this.panelBanner.Name = "panelBanner";
            this.panelBanner.Size = new System.Drawing.Size(894, 106);
            this.panelBanner.TabIndex = 0;
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.BackgroundImage = global::DomnPhil_Construction.Properties.Resources.settings;
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Location = new System.Drawing.Point(842, 112);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(40, 40);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.Font = new System.Drawing.Font("Poppins", 10F);
            this.btnEmployees.Location = new System.Drawing.Point(362, 449);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(170, 34);
            this.btnEmployees.TabIndex = 1;
            this.btnEmployees.Text = "E&mployees";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnAttendance
            // 
            this.btnAttendance.Font = new System.Drawing.Font("Poppins", 10F);
            this.btnAttendance.Location = new System.Drawing.Point(537, 449);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Size = new System.Drawing.Size(170, 34);
            this.btnAttendance.TabIndex = 1;
            this.btnAttendance.Text = "&Attendance";
            this.btnAttendance.UseVisualStyleBackColor = true;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // btnCashAdvanceLoan
            // 
            this.btnCashAdvanceLoan.Font = new System.Drawing.Font("Poppins", 10F);
            this.btnCashAdvanceLoan.Location = new System.Drawing.Point(712, 449);
            this.btnCashAdvanceLoan.Name = "btnCashAdvanceLoan";
            this.btnCashAdvanceLoan.Size = new System.Drawing.Size(170, 34);
            this.btnCashAdvanceLoan.TabIndex = 1;
            this.btnCashAdvanceLoan.Text = "&Cash Advance / Loan";
            this.btnCashAdvanceLoan.UseVisualStyleBackColor = true;
            this.btnCashAdvanceLoan.Click += new System.EventHandler(this.btnCashAdvanceLoan_Click);
            // 
            // btnEquipments
            // 
            this.btnEquipments.Font = new System.Drawing.Font("Poppins", 10F);
            this.btnEquipments.Location = new System.Drawing.Point(187, 449);
            this.btnEquipments.Name = "btnEquipments";
            this.btnEquipments.Size = new System.Drawing.Size(170, 34);
            this.btnEquipments.TabIndex = 1;
            this.btnEquipments.Text = "E&quipments";
            this.btnEquipments.UseVisualStyleBackColor = true;
            this.btnEquipments.Click += new System.EventHandler(this.btnEquipments_Click);
            // 
            // btnPurchaseOrders
            // 
            this.btnPurchaseOrders.Font = new System.Drawing.Font("Poppins", 10F);
            this.btnPurchaseOrders.Location = new System.Drawing.Point(12, 449);
            this.btnPurchaseOrders.Name = "btnPurchaseOrders";
            this.btnPurchaseOrders.Size = new System.Drawing.Size(170, 34);
            this.btnPurchaseOrders.TabIndex = 1;
            this.btnPurchaseOrders.Text = "&Purchase Orders";
            this.btnPurchaseOrders.UseVisualStyleBackColor = true;
            this.btnPurchaseOrders.Click += new System.EventHandler(this.btnPurchaseOrders_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::DomnPhil_Construction.Properties.Resources.Asset_1_3x;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(894, 509);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnCashAdvanceLoan);
            this.Controls.Add(this.btnAttendance);
            this.Controls.Add(this.btnPurchaseOrders);
            this.Controls.Add(this.btnEquipments);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.panelBanner);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Domnphil Construction System - Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBanner;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Button btnCashAdvanceLoan;
        private System.Windows.Forms.Button btnEquipments;
        private System.Windows.Forms.Button btnPurchaseOrders;
        private System.Windows.Forms.Button btnSettings;
    }
}