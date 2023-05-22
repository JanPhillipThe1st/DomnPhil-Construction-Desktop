
namespace DomnPhil_Construction
{
    partial class Repair_Records
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Repair_Records));
            this.label3 = new System.Windows.Forms.Label();
            this.gbEmployeeDetails = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.gbSupplierInformation = new System.Windows.Forms.GroupBox();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.btnSavePurchaseOrder = new System.Windows.Forms.Button();
            this.dgvPurchaseOrders = new System.Windows.Forms.DataGridView();
            this.dtpRepairDate = new System.Windows.Forms.DateTimePicker();
            this.dtpRepairFinish = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbRepairRemarks = new System.Windows.Forms.TextBox();
            this.tbTotalRepairCost = new System.Windows.Forms.TextBox();
            this.tbShopName = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbEmployeeDetails.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbSupplierInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9F);
            this.label3.Location = new System.Drawing.Point(16, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Shop Name";
            // 
            // gbEmployeeDetails
            // 
            this.gbEmployeeDetails.Controls.Add(this.groupBox1);
            this.gbEmployeeDetails.Controls.Add(this.gbSupplierInformation);
            this.gbEmployeeDetails.Controls.Add(this.btnSavePurchaseOrder);
            this.gbEmployeeDetails.Controls.Add(this.dgvPurchaseOrders);
            this.gbEmployeeDetails.Controls.Add(this.dtpRepairDate);
            this.gbEmployeeDetails.Controls.Add(this.dtpRepairFinish);
            this.gbEmployeeDetails.Controls.Add(this.label11);
            this.gbEmployeeDetails.Controls.Add(this.label8);
            this.gbEmployeeDetails.Controls.Add(this.label4);
            this.gbEmployeeDetails.Controls.Add(this.label2);
            this.gbEmployeeDetails.Controls.Add(this.label5);
            this.gbEmployeeDetails.Controls.Add(this.label3);
            this.gbEmployeeDetails.Controls.Add(this.tbRepairRemarks);
            this.gbEmployeeDetails.Controls.Add(this.tbTotalRepairCost);
            this.gbEmployeeDetails.Controls.Add(this.tbShopName);
            this.gbEmployeeDetails.Font = new System.Drawing.Font("Poppins", 10F);
            this.gbEmployeeDetails.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbEmployeeDetails.Location = new System.Drawing.Point(20, 33);
            this.gbEmployeeDetails.Name = "gbEmployeeDetails";
            this.gbEmployeeDetails.Size = new System.Drawing.Size(1368, 651);
            this.gbEmployeeDetails.TabIndex = 0;
            this.gbEmployeeDetails.TabStop = false;
            this.gbEmployeeDetails.Text = "Repair Records";
            this.gbEmployeeDetails.Enter += new System.EventHandler(this.gbEmployeeDetails_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(417, 328);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 278);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Replaced Parts";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Poppins", 8F);
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(210, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 24);
            this.button2.TabIndex = 3;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // gbSupplierInformation
            // 
            this.gbSupplierInformation.Controls.Add(this.btnAddSupplier);
            this.gbSupplierInformation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbSupplierInformation.Location = new System.Drawing.Point(417, 43);
            this.gbSupplierInformation.Name = "gbSupplierInformation";
            this.gbSupplierInformation.Size = new System.Drawing.Size(306, 278);
            this.gbSupplierInformation.TabIndex = 32;
            this.gbSupplierInformation.TabStop = false;
            this.gbSupplierInformation.Text = "Repaired Parts";
            this.gbSupplierInformation.Enter += new System.EventHandler(this.gbSupplierInformation_Enter);
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAddSupplier.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddSupplier.FlatAppearance.BorderSize = 0;
            this.btnAddSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSupplier.Font = new System.Drawing.Font("Poppins", 8F);
            this.btnAddSupplier.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddSupplier.Location = new System.Drawing.Point(210, 248);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(90, 24);
            this.btnAddSupplier.TabIndex = 3;
            this.btnAddSupplier.Text = "Add Part";
            this.btnAddSupplier.UseVisualStyleBackColor = false;
            // 
            // btnSavePurchaseOrder
            // 
            this.btnSavePurchaseOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSavePurchaseOrder.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSavePurchaseOrder.FlatAppearance.BorderSize = 0;
            this.btnSavePurchaseOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePurchaseOrder.Font = new System.Drawing.Font("Poppins", 10F);
            this.btnSavePurchaseOrder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSavePurchaseOrder.Location = new System.Drawing.Point(187, 393);
            this.btnSavePurchaseOrder.Name = "btnSavePurchaseOrder";
            this.btnSavePurchaseOrder.Size = new System.Drawing.Size(200, 31);
            this.btnSavePurchaseOrder.TabIndex = 3;
            this.btnSavePurchaseOrder.Text = "Save";
            this.btnSavePurchaseOrder.UseVisualStyleBackColor = false;
            this.btnSavePurchaseOrder.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvPurchaseOrders
            // 
            this.dgvPurchaseOrders.AllowUserToAddRows = false;
            this.dgvPurchaseOrders.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvPurchaseOrders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPurchaseOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPurchaseOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPurchaseOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchaseOrders.EnableHeadersVisualStyles = false;
            this.dgvPurchaseOrders.Location = new System.Drawing.Point(753, 69);
            this.dgvPurchaseOrders.MultiSelect = false;
            this.dgvPurchaseOrders.Name = "dgvPurchaseOrders";
            this.dgvPurchaseOrders.ReadOnly = true;
            this.dgvPurchaseOrders.RowHeadersVisible = false;
            this.dgvPurchaseOrders.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvPurchaseOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPurchaseOrders.Size = new System.Drawing.Size(595, 537);
            this.dgvPurchaseOrders.TabIndex = 30;
            // 
            // dtpRepairDate
            // 
            this.dtpRepairDate.Location = new System.Drawing.Point(16, 180);
            this.dtpRepairDate.Name = "dtpRepairDate";
            this.dtpRepairDate.Size = new System.Drawing.Size(371, 27);
            this.dtpRepairDate.TabIndex = 22;
            // 
            // dtpRepairFinish
            // 
            this.dtpRepairFinish.Location = new System.Drawing.Point(16, 240);
            this.dtpRepairFinish.Name = "dtpRepairFinish";
            this.dtpRepairFinish.Size = new System.Drawing.Size(371, 27);
            this.dtpRepairFinish.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Poppins", 9F);
            this.label11.Location = new System.Drawing.Point(16, 215);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 22);
            this.label11.TabIndex = 4;
            this.label11.Text = "Date Repair Finished";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 9F);
            this.label8.Location = new System.Drawing.Point(16, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 22);
            this.label8.TabIndex = 4;
            this.label8.Text = "Date of Repair";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 9F);
            this.label4.Location = new System.Drawing.Point(16, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Repair Remarks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9F);
            this.label2.Location = new System.Drawing.Point(16, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total Repair Cost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 11F);
            this.label5.Location = new System.Drawing.Point(748, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Repair Records";
            // 
            // tbRepairRemarks
            // 
            this.tbRepairRemarks.Font = new System.Drawing.Font("Poppins", 9F);
            this.tbRepairRemarks.Location = new System.Drawing.Point(16, 306);
            this.tbRepairRemarks.Margin = new System.Windows.Forms.Padding(4);
            this.tbRepairRemarks.Multiline = true;
            this.tbRepairRemarks.Name = "tbRepairRemarks";
            this.tbRepairRemarks.Size = new System.Drawing.Size(371, 78);
            this.tbRepairRemarks.TabIndex = 4;
            this.tbRepairRemarks.TextChanged += new System.EventHandler(this.tbNonOperationalDays_TextChanged);
            // 
            // tbTotalRepairCost
            // 
            this.tbTotalRepairCost.Font = new System.Drawing.Font("Poppins", 9F);
            this.tbTotalRepairCost.Location = new System.Drawing.Point(16, 124);
            this.tbTotalRepairCost.Margin = new System.Windows.Forms.Padding(4);
            this.tbTotalRepairCost.Name = "tbTotalRepairCost";
            this.tbTotalRepairCost.Size = new System.Drawing.Size(371, 25);
            this.tbTotalRepairCost.TabIndex = 0;
            this.tbTotalRepairCost.TextChanged += new System.EventHandler(this.tbNonOperationalDays_TextChanged);
            // 
            // tbShopName
            // 
            this.tbShopName.Font = new System.Drawing.Font("Poppins", 9F);
            this.tbShopName.Location = new System.Drawing.Point(16, 69);
            this.tbShopName.Margin = new System.Windows.Forms.Padding(4);
            this.tbShopName.Name = "tbShopName";
            this.tbShopName.Size = new System.Drawing.Size(371, 25);
            this.tbShopName.TabIndex = 0;
            this.tbShopName.TextChanged += new System.EventHandler(this.tbNonOperationalDays_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Repair_Records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1409, 696);
            this.Controls.Add(this.gbEmployeeDetails);
            this.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Repair_Records";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DomnPhil Equipments - Repair Records";
            this.Load += new System.EventHandler(this.Employees_Load);
            this.gbEmployeeDetails.ResumeLayout(false);
            this.gbEmployeeDetails.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.gbSupplierInformation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbEmployeeDetails;
        private System.Windows.Forms.TextBox tbShopName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbRepairRemarks;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPurchaseOrders;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSavePurchaseOrder;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker dtpRepairFinish;
        private System.Windows.Forms.DateTimePicker dtpRepairDate;
        private System.Windows.Forms.TextBox tbTotalRepairCost;
        private System.Windows.Forms.GroupBox gbSupplierInformation;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
    }
}

