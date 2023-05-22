
namespace DomnPhil_Construction
{
    partial class Purchase_Order_Items
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.gbEmployeeDetails = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.gbPurchaseOrderItem = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbTotalAmount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDiscount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbUnitCost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUnit = new System.Windows.Forms.TextBox();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.dgvPurchaseOrderItems = new System.Windows.Forms.DataGridView();
            this.lblPurchaseOrderTotal = new System.Windows.Forms.Label();
            this.lblTableLabel = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnEdit = new System.Windows.Forms.Button();
            this.gbEmployeeDetails.SuspendLayout();
            this.gbPurchaseOrderItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseOrderItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9F);
            this.label3.Location = new System.Drawing.Point(16, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantity";
            // 
            // gbEmployeeDetails
            // 
            this.gbEmployeeDetails.Controls.Add(this.btnPrint);
            this.gbEmployeeDetails.Controls.Add(this.gbPurchaseOrderItem);
            this.gbEmployeeDetails.Controls.Add(this.dgvPurchaseOrderItems);
            this.gbEmployeeDetails.Controls.Add(this.lblPurchaseOrderTotal);
            this.gbEmployeeDetails.Controls.Add(this.lblTableLabel);
            this.gbEmployeeDetails.Font = new System.Drawing.Font("Poppins", 10F);
            this.gbEmployeeDetails.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbEmployeeDetails.Location = new System.Drawing.Point(20, 48);
            this.gbEmployeeDetails.Name = "gbEmployeeDetails";
            this.gbEmployeeDetails.Size = new System.Drawing.Size(1368, 607);
            this.gbEmployeeDetails.TabIndex = 0;
            this.gbEmployeeDetails.TabStop = false;
            this.gbEmployeeDetails.Text = "Purchase Order";
            this.gbEmployeeDetails.Enter += new System.EventHandler(this.gbEmployeeDetails_Enter);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Gainsboro;
            this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Poppins", 10F);
            this.btnPrint.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPrint.Image = global::DomnPhil_Construction.Properties.Resources.flat_blue_printer1;
            this.btnPrint.Location = new System.Drawing.Point(1145, 546);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(217, 54);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "Print Purchase Order";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // gbPurchaseOrderItem
            // 
            this.gbPurchaseOrderItem.Controls.Add(this.btnSave);
            this.gbPurchaseOrderItem.Controls.Add(this.label8);
            this.gbPurchaseOrderItem.Controls.Add(this.tbTotalAmount);
            this.gbPurchaseOrderItem.Controls.Add(this.label7);
            this.gbPurchaseOrderItem.Controls.Add(this.tbDiscount);
            this.gbPurchaseOrderItem.Controls.Add(this.label6);
            this.gbPurchaseOrderItem.Controls.Add(this.tbUnitCost);
            this.gbPurchaseOrderItem.Controls.Add(this.label4);
            this.gbPurchaseOrderItem.Controls.Add(this.tbDescription);
            this.gbPurchaseOrderItem.Controls.Add(this.label1);
            this.gbPurchaseOrderItem.Controls.Add(this.tbUnit);
            this.gbPurchaseOrderItem.Controls.Add(this.label3);
            this.gbPurchaseOrderItem.Controls.Add(this.tbQuantity);
            this.gbPurchaseOrderItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbPurchaseOrderItem.Location = new System.Drawing.Point(21, 53);
            this.gbPurchaseOrderItem.Name = "gbPurchaseOrderItem";
            this.gbPurchaseOrderItem.Size = new System.Drawing.Size(494, 461);
            this.gbPurchaseOrderItem.TabIndex = 31;
            this.gbPurchaseOrderItem.TabStop = false;
            this.gbPurchaseOrderItem.Text = "Add New Item";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Poppins", 10F);
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Location = new System.Drawing.Point(337, 378);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(142, 33);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 9F);
            this.label8.Location = new System.Drawing.Point(16, 306);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 22);
            this.label8.TabIndex = 4;
            this.label8.Text = "Total Amount";
            // 
            // tbTotalAmount
            // 
            this.tbTotalAmount.Enabled = false;
            this.tbTotalAmount.Font = new System.Drawing.Font("Poppins", 9F);
            this.tbTotalAmount.Location = new System.Drawing.Point(16, 332);
            this.tbTotalAmount.Margin = new System.Windows.Forms.Padding(4);
            this.tbTotalAmount.Name = "tbTotalAmount";
            this.tbTotalAmount.Size = new System.Drawing.Size(463, 25);
            this.tbTotalAmount.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 9F);
            this.label7.Location = new System.Drawing.Point(16, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 22);
            this.label7.TabIndex = 4;
            this.label7.Text = "Discount";
            // 
            // tbDiscount
            // 
            this.tbDiscount.Font = new System.Drawing.Font("Poppins", 9F);
            this.tbDiscount.Location = new System.Drawing.Point(16, 277);
            this.tbDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.tbDiscount.Name = "tbDiscount";
            this.tbDiscount.Size = new System.Drawing.Size(463, 25);
            this.tbDiscount.TabIndex = 0;
            this.tbDiscount.TextChanged += new System.EventHandler(this.tbDiscount_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 9F);
            this.label6.Location = new System.Drawing.Point(16, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = "Unit Cost";
            // 
            // tbUnitCost
            // 
            this.tbUnitCost.Font = new System.Drawing.Font("Poppins", 9F);
            this.tbUnitCost.Location = new System.Drawing.Point(16, 222);
            this.tbUnitCost.Margin = new System.Windows.Forms.Padding(4);
            this.tbUnitCost.Name = "tbUnitCost";
            this.tbUnitCost.Size = new System.Drawing.Size(463, 25);
            this.tbUnitCost.TabIndex = 0;
            this.tbUnitCost.TextChanged += new System.EventHandler(this.tbUnitCost_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 9F);
            this.label4.Location = new System.Drawing.Point(16, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Description";
            // 
            // tbDescription
            // 
            this.tbDescription.Font = new System.Drawing.Font("Poppins", 9F);
            this.tbDescription.Location = new System.Drawing.Point(16, 167);
            this.tbDescription.Margin = new System.Windows.Forms.Padding(4);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(463, 25);
            this.tbDescription.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 9F);
            this.label1.Location = new System.Drawing.Point(16, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Unit";
            // 
            // tbUnit
            // 
            this.tbUnit.Font = new System.Drawing.Font("Poppins", 9F);
            this.tbUnit.Location = new System.Drawing.Point(16, 112);
            this.tbUnit.Margin = new System.Windows.Forms.Padding(4);
            this.tbUnit.Name = "tbUnit";
            this.tbUnit.Size = new System.Drawing.Size(463, 25);
            this.tbUnit.TabIndex = 0;
            // 
            // tbQuantity
            // 
            this.tbQuantity.Font = new System.Drawing.Font("Poppins", 9F);
            this.tbQuantity.Location = new System.Drawing.Point(16, 57);
            this.tbQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(463, 25);
            this.tbQuantity.TabIndex = 0;
            this.tbQuantity.TextChanged += new System.EventHandler(this.tbQuantity_TextChanged);
            // 
            // dgvPurchaseOrderItems
            // 
            this.dgvPurchaseOrderItems.AllowUserToAddRows = false;
            this.dgvPurchaseOrderItems.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvPurchaseOrderItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPurchaseOrderItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Poppins", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPurchaseOrderItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPurchaseOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchaseOrderItems.EnableHeadersVisualStyles = false;
            this.dgvPurchaseOrderItems.Location = new System.Drawing.Point(521, 63);
            this.dgvPurchaseOrderItems.MultiSelect = false;
            this.dgvPurchaseOrderItems.Name = "dgvPurchaseOrderItems";
            this.dgvPurchaseOrderItems.ReadOnly = true;
            this.dgvPurchaseOrderItems.RowHeadersVisible = false;
            this.dgvPurchaseOrderItems.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvPurchaseOrderItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPurchaseOrderItems.Size = new System.Drawing.Size(841, 451);
            this.dgvPurchaseOrderItems.TabIndex = 30;
            this.dgvPurchaseOrderItems.DataSourceChanged += new System.EventHandler(this.dgvPurchaseOrderItems_DataSourceChanged);
            this.dgvPurchaseOrderItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPurchaseOrderItems_CellContentClick);
            // 
            // lblPurchaseOrderTotal
            // 
            this.lblPurchaseOrderTotal.AutoSize = true;
            this.lblPurchaseOrderTotal.Font = new System.Drawing.Font("Poppins", 11F);
            this.lblPurchaseOrderTotal.Location = new System.Drawing.Point(975, 517);
            this.lblPurchaseOrderTotal.Name = "lblPurchaseOrderTotal";
            this.lblPurchaseOrderTotal.Size = new System.Drawing.Size(174, 26);
            this.lblPurchaseOrderTotal.TabIndex = 4;
            this.lblPurchaseOrderTotal.Text = "Purchase Order Total:";
            // 
            // lblTableLabel
            // 
            this.lblTableLabel.AutoSize = true;
            this.lblTableLabel.Font = new System.Drawing.Font("Poppins", 11F);
            this.lblTableLabel.Location = new System.Drawing.Point(516, 34);
            this.lblTableLabel.Name = "lblTableLabel";
            this.lblTableLabel.Size = new System.Drawing.Size(195, 26);
            this.lblTableLabel.TabIndex = 4;
            this.lblTableLabel.Text = "Items in purchase order:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Poppins", 10F);
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEdit.Location = new System.Drawing.Point(1198, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(190, 30);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit Purchase Order";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // Purchase_Order_Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1409, 673);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.gbEmployeeDetails);
            this.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Purchase_Order_Items";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DomnPhil Purchasing - Purchase Order Items";
            this.Load += new System.EventHandler(this.Employees_Load);
            this.gbEmployeeDetails.ResumeLayout(false);
            this.gbEmployeeDetails.PerformLayout();
            this.gbPurchaseOrderItem.ResumeLayout(false);
            this.gbPurchaseOrderItem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseOrderItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbEmployeeDetails;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.DataGridView dgvPurchaseOrderItems;
        private System.Windows.Forms.Label lblTableLabel;
        private System.Windows.Forms.GroupBox gbPurchaseOrderItem;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbUnitCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUnit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbDiscount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbTotalAmount;
        private System.Windows.Forms.Label lblPurchaseOrderTotal;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnEdit;
    }
}

