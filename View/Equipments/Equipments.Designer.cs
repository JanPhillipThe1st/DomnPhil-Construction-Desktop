
namespace DomnPhil_Construction.View.Equipments
{
    partial class Equipments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbSites = new System.Windows.Forms.ComboBox();
            this.dgvEquipments = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSearchEmployee = new System.Windows.Forms.TextBox();
            this.gbEquipments = new System.Windows.Forms.GroupBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEquipmentRepair = new System.Windows.Forms.Button();
            this.btnAddNewEquipment = new System.Windows.Forms.Button();
            this.bannerPanel = new System.Windows.Forms.Panel();
            this.btnPrintReport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipments)).BeginInit();
            this.gbEquipments.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbSites
            // 
            this.cbSites.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSites.Font = new System.Drawing.Font("Poppins", 10F);
            this.cbSites.FormattingEnabled = true;
            this.cbSites.Location = new System.Drawing.Point(182, 43);
            this.cbSites.Name = "cbSites";
            this.cbSites.Size = new System.Drawing.Size(347, 31);
            this.cbSites.TabIndex = 11;
            this.cbSites.SelectedIndexChanged += new System.EventHandler(this.cbSites_SelectedIndexChanged);
            // 
            // dgvEquipments
            // 
            this.dgvEquipments.AllowUserToAddRows = false;
            this.dgvEquipments.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvEquipments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEquipments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Poppins", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEquipments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEquipments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipments.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvEquipments.EnableHeadersVisualStyles = false;
            this.dgvEquipments.Location = new System.Drawing.Point(0, 299);
            this.dgvEquipments.MultiSelect = false;
            this.dgvEquipments.Name = "dgvEquipments";
            this.dgvEquipments.ReadOnly = true;
            this.dgvEquipments.RowHeadersVisible = false;
            this.dgvEquipments.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvEquipments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEquipments.Size = new System.Drawing.Size(1441, 301);
            this.dgvEquipments.TabIndex = 10;
            this.dgvEquipments.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEquipments_CellDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 10F);
            this.label3.Location = new System.Drawing.Point(17, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Filter by site";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 10F);
            this.label1.Location = new System.Drawing.Point(17, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Search Equipment";
            // 
            // tbSearchEmployee
            // 
            this.tbSearchEmployee.Font = new System.Drawing.Font("Poppins", 10F);
            this.tbSearchEmployee.Location = new System.Drawing.Point(182, 77);
            this.tbSearchEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearchEmployee.Name = "tbSearchEmployee";
            this.tbSearchEmployee.Size = new System.Drawing.Size(347, 27);
            this.tbSearchEmployee.TabIndex = 6;
            this.tbSearchEmployee.TextChanged += new System.EventHandler(this.tbSearchEmployee_TextChanged);
            // 
            // gbEquipments
            // 
            this.gbEquipments.Controls.Add(this.lblCount);
            this.gbEquipments.Controls.Add(this.btnDelete);
            this.gbEquipments.Controls.Add(this.btnPrintReport);
            this.gbEquipments.Controls.Add(this.btnEquipmentRepair);
            this.gbEquipments.Controls.Add(this.btnAddNewEquipment);
            this.gbEquipments.Controls.Add(this.label3);
            this.gbEquipments.Controls.Add(this.cbSites);
            this.gbEquipments.Controls.Add(this.tbSearchEmployee);
            this.gbEquipments.Controls.Add(this.label1);
            this.gbEquipments.Font = new System.Drawing.Font("Poppins Medium", 12.75F, System.Drawing.FontStyle.Bold);
            this.gbEquipments.Location = new System.Drawing.Point(12, 122);
            this.gbEquipments.Name = "gbEquipments";
            this.gbEquipments.Size = new System.Drawing.Size(1417, 171);
            this.gbEquipments.TabIndex = 12;
            this.gbEquipments.TabStop = false;
            this.gbEquipments.Text = "Equipments";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(178, 108);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(58, 20);
            this.lblCount.TabIndex = 13;
            this.lblCount.Text = "Count:";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Poppins", 10F);
            this.btnDelete.Location = new System.Drawing.Point(1229, 64);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(182, 31);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete Equipment";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEquipmentRepair
            // 
            this.btnEquipmentRepair.Font = new System.Drawing.Font("Poppins", 10F);
            this.btnEquipmentRepair.Location = new System.Drawing.Point(1229, 134);
            this.btnEquipmentRepair.Name = "btnEquipmentRepair";
            this.btnEquipmentRepair.Size = new System.Drawing.Size(182, 31);
            this.btnEquipmentRepair.TabIndex = 12;
            this.btnEquipmentRepair.Text = "Repair Records";
            this.btnEquipmentRepair.UseVisualStyleBackColor = true;
            this.btnEquipmentRepair.Click += new System.EventHandler(this.btnEquipmentRepair_Click);
            // 
            // btnAddNewEquipment
            // 
            this.btnAddNewEquipment.Font = new System.Drawing.Font("Poppins", 10F);
            this.btnAddNewEquipment.Location = new System.Drawing.Point(1229, 29);
            this.btnAddNewEquipment.Name = "btnAddNewEquipment";
            this.btnAddNewEquipment.Size = new System.Drawing.Size(182, 31);
            this.btnAddNewEquipment.TabIndex = 12;
            this.btnAddNewEquipment.Text = "Add New Equipment";
            this.btnAddNewEquipment.UseVisualStyleBackColor = true;
            this.btnAddNewEquipment.Click += new System.EventHandler(this.btnAddNewEquipment_Click);
            // 
            // bannerPanel
            // 
            this.bannerPanel.BackgroundImage = global::DomnPhil_Construction.Properties.Resources.LONG_DOMNPHIL_CONSTRUCTION_LOGO___NEN;
            this.bannerPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bannerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.bannerPanel.Location = new System.Drawing.Point(0, 0);
            this.bannerPanel.Margin = new System.Windows.Forms.Padding(4);
            this.bannerPanel.Name = "bannerPanel";
            this.bannerPanel.Size = new System.Drawing.Size(1441, 115);
            this.bannerPanel.TabIndex = 1;
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.Font = new System.Drawing.Font("Poppins", 10F);
            this.btnPrintReport.Location = new System.Drawing.Point(182, 131);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(347, 31);
            this.btnPrintReport.TabIndex = 12;
            this.btnPrintReport.Text = "Print Equipment Report";
            this.btnPrintReport.UseVisualStyleBackColor = true;
            this.btnPrintReport.Click += new System.EventHandler(this.btnPrintReport_Click);
            // 
            // Equipments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1441, 600);
            this.Controls.Add(this.gbEquipments);
            this.Controls.Add(this.dgvEquipments);
            this.Controls.Add(this.bannerPanel);
            this.Font = new System.Drawing.Font("Poppins", 10F);
            this.Name = "Equipments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Domnphil Construction System - Equipment List - All Equipments";
            this.Load += new System.EventHandler(this.Equipments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipments)).EndInit();
            this.gbEquipments.ResumeLayout(false);
            this.gbEquipments.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bannerPanel;
        private System.Windows.Forms.ComboBox cbSites;
        private System.Windows.Forms.DataGridView dgvEquipments;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearchEmployee;
        private System.Windows.Forms.GroupBox gbEquipments;
        private System.Windows.Forms.Button btnAddNewEquipment;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnEquipmentRepair;
        private System.Windows.Forms.Button btnPrintReport;
    }
}