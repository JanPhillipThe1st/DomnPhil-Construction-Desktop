
namespace DomnPhil_Construction.View.Purchase_Orders
{
    partial class Purchase_Orders
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Purchase_Orders));
            this.cbSites = new System.Windows.Forms.ComboBox();
            this.dgvPurchaseOrders = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSearchEmployee = new System.Windows.Forms.TextBox();
            this.gbEquipments = new System.Windows.Forms.GroupBox();
            this.btnDeletePurchaseOrder = new System.Windows.Forms.Button();
            this.btnAddNewPurchaseOrder = new System.Windows.Forms.Button();
            this.bannerPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseOrders)).BeginInit();
            this.gbEquipments.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbSites
            // 
            this.cbSites.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSites.Font = new System.Drawing.Font("Poppins", 10F);
            this.cbSites.FormattingEnabled = true;
            this.cbSites.Location = new System.Drawing.Point(231, 35);
            this.cbSites.Name = "cbSites";
            this.cbSites.Size = new System.Drawing.Size(238, 31);
            this.cbSites.TabIndex = 11;
            this.cbSites.SelectedIndexChanged += new System.EventHandler(this.cbSites_SelectedIndexChanged);
            // 
            // dgvPurchaseOrders
            // 
            this.dgvPurchaseOrders.AllowUserToAddRows = false;
            this.dgvPurchaseOrders.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvPurchaseOrders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPurchaseOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPurchaseOrders.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPurchaseOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPurchaseOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchaseOrders.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPurchaseOrders.EnableHeadersVisualStyles = false;
            this.dgvPurchaseOrders.Location = new System.Drawing.Point(0, 289);
            this.dgvPurchaseOrders.MultiSelect = false;
            this.dgvPurchaseOrders.Name = "dgvPurchaseOrders";
            this.dgvPurchaseOrders.ReadOnly = true;
            this.dgvPurchaseOrders.RowHeadersVisible = false;
            this.dgvPurchaseOrders.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvPurchaseOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPurchaseOrders.Size = new System.Drawing.Size(895, 311);
            this.dgvPurchaseOrders.TabIndex = 10;
            this.dgvPurchaseOrders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPurchaseOrders_CellDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 10F);
            this.label3.Location = new System.Drawing.Point(17, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Filter by site";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 10F);
            this.label1.Location = new System.Drawing.Point(17, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Search Purchase Order";
            // 
            // tbSearchEmployee
            // 
            this.tbSearchEmployee.Font = new System.Drawing.Font("Poppins", 10F);
            this.tbSearchEmployee.Location = new System.Drawing.Point(231, 83);
            this.tbSearchEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.tbSearchEmployee.Name = "tbSearchEmployee";
            this.tbSearchEmployee.Size = new System.Drawing.Size(238, 27);
            this.tbSearchEmployee.TabIndex = 6;
            this.tbSearchEmployee.TextChanged += new System.EventHandler(this.tbSearchEmployee_TextChanged);
            // 
            // gbEquipments
            // 
            this.gbEquipments.Controls.Add(this.btnDeletePurchaseOrder);
            this.gbEquipments.Controls.Add(this.btnAddNewPurchaseOrder);
            this.gbEquipments.Controls.Add(this.label3);
            this.gbEquipments.Controls.Add(this.cbSites);
            this.gbEquipments.Controls.Add(this.tbSearchEmployee);
            this.gbEquipments.Controls.Add(this.label1);
            this.gbEquipments.Font = new System.Drawing.Font("Poppins Medium", 12.75F, System.Drawing.FontStyle.Bold);
            this.gbEquipments.Location = new System.Drawing.Point(12, 134);
            this.gbEquipments.Name = "gbEquipments";
            this.gbEquipments.Size = new System.Drawing.Size(870, 128);
            this.gbEquipments.TabIndex = 12;
            this.gbEquipments.TabStop = false;
            this.gbEquipments.Text = "Purchase Orders";
            this.gbEquipments.Enter += new System.EventHandler(this.gbEquipments_Enter);
            // 
            // btnDeletePurchaseOrder
            // 
            this.btnDeletePurchaseOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeletePurchaseOrder.Font = new System.Drawing.Font("Poppins", 10F);
            this.btnDeletePurchaseOrder.Location = new System.Drawing.Point(635, 79);
            this.btnDeletePurchaseOrder.Name = "btnDeletePurchaseOrder";
            this.btnDeletePurchaseOrder.Size = new System.Drawing.Size(217, 31);
            this.btnDeletePurchaseOrder.TabIndex = 12;
            this.btnDeletePurchaseOrder.Text = "Delete Purchase Order";
            this.btnDeletePurchaseOrder.UseVisualStyleBackColor = true;
            this.btnDeletePurchaseOrder.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddNewPurchaseOrder
            // 
            this.btnAddNewPurchaseOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewPurchaseOrder.Font = new System.Drawing.Font("Poppins", 10F);
            this.btnAddNewPurchaseOrder.Location = new System.Drawing.Point(635, 35);
            this.btnAddNewPurchaseOrder.Name = "btnAddNewPurchaseOrder";
            this.btnAddNewPurchaseOrder.Size = new System.Drawing.Size(217, 31);
            this.btnAddNewPurchaseOrder.TabIndex = 12;
            this.btnAddNewPurchaseOrder.Text = "Add New Purchase Order";
            this.btnAddNewPurchaseOrder.UseVisualStyleBackColor = true;
            this.btnAddNewPurchaseOrder.Click += new System.EventHandler(this.btnAddNewEquipment_Click);
            // 
            // bannerPanel
            // 
            this.bannerPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bannerPanel.BackgroundImage")));
            this.bannerPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bannerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.bannerPanel.Location = new System.Drawing.Point(0, 0);
            this.bannerPanel.Margin = new System.Windows.Forms.Padding(4);
            this.bannerPanel.Name = "bannerPanel";
            this.bannerPanel.Size = new System.Drawing.Size(895, 113);
            this.bannerPanel.TabIndex = 1;
            // 
            // Purchase_Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(895, 600);
            this.Controls.Add(this.gbEquipments);
            this.Controls.Add(this.dgvPurchaseOrders);
            this.Controls.Add(this.bannerPanel);
            this.Font = new System.Drawing.Font("Poppins", 10F);
            this.Name = "Purchase_Orders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Domnphil Construction System - Purchase Orders - Search Purchase Orders";
            this.Load += new System.EventHandler(this.Equipments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseOrders)).EndInit();
            this.gbEquipments.ResumeLayout(false);
            this.gbEquipments.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bannerPanel;
        private System.Windows.Forms.ComboBox cbSites;
        private System.Windows.Forms.DataGridView dgvPurchaseOrders;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSearchEmployee;
        private System.Windows.Forms.GroupBox gbEquipments;
        private System.Windows.Forms.Button btnAddNewPurchaseOrder;
        private System.Windows.Forms.Button btnDeletePurchaseOrder;
    }
}