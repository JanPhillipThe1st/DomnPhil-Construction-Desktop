
namespace DomnPhil_Construction
{
    partial class Edit_Purchase_Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_Purchase_Order));
            this.btnAddRequester = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.gbEmployeeDetails = new System.Windows.Forms.GroupBox();
            this.btnSavePurchaseOrder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEditRequester = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.lblRequesterID = new System.Windows.Forms.Label();
            this.lblRequesterContact = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblRequesterName = new System.Windows.Forms.Label();
            this.lblRequesterDesignation = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.gbSupplierInformation = new System.Windows.Forms.GroupBox();
            this.btnEditSupplier = new System.Windows.Forms.Button();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.label27 = new System.Windows.Forms.Label();
            this.lblSupplierID = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblContactNumber = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.lblSupplierAddress = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.cbRequester = new System.Windows.Forms.ComboBox();
            this.cbModeOfPayment = new System.Windows.Forms.ComboBox();
            this.cbSupplierList = new System.Windows.Forms.ComboBox();
            this.dtpDateCreated = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSites = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbRemarks = new System.Windows.Forms.TextBox();
            this.tbProjectID = new System.Windows.Forms.TextBox();
            this.tbPartialPayment = new System.Windows.Forms.TextBox();
            this.tbCharges = new System.Windows.Forms.TextBox();
            this.tbDeliveredTo = new System.Windows.Forms.TextBox();
            this.tbControlNumber = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbEmployeeDetails.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbSupplierInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddRequester
            // 
            this.btnAddRequester.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAddRequester.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddRequester.FlatAppearance.BorderSize = 0;
            this.btnAddRequester.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRequester.Font = new System.Drawing.Font("Poppins", 8F);
            this.btnAddRequester.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddRequester.Location = new System.Drawing.Point(210, 189);
            this.btnAddRequester.Name = "btnAddRequester";
            this.btnAddRequester.Size = new System.Drawing.Size(90, 24);
            this.btnAddRequester.TabIndex = 3;
            this.btnAddRequester.Text = "Add New";
            this.btnAddRequester.UseVisualStyleBackColor = false;
            this.btnAddRequester.Click += new System.EventHandler(this.btnAddRequester_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9F);
            this.label3.Location = new System.Drawing.Point(21, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Control Number";
            // 
            // gbEmployeeDetails
            // 
            this.gbEmployeeDetails.Controls.Add(this.btnSavePurchaseOrder);
            this.gbEmployeeDetails.Controls.Add(this.groupBox1);
            this.gbEmployeeDetails.Controls.Add(this.gbSupplierInformation);
            this.gbEmployeeDetails.Controls.Add(this.cbRequester);
            this.gbEmployeeDetails.Controls.Add(this.cbModeOfPayment);
            this.gbEmployeeDetails.Controls.Add(this.cbSupplierList);
            this.gbEmployeeDetails.Controls.Add(this.dtpDateCreated);
            this.gbEmployeeDetails.Controls.Add(this.label10);
            this.gbEmployeeDetails.Controls.Add(this.label11);
            this.gbEmployeeDetails.Controls.Add(this.label7);
            this.gbEmployeeDetails.Controls.Add(this.label18);
            this.gbEmployeeDetails.Controls.Add(this.label1);
            this.gbEmployeeDetails.Controls.Add(this.label9);
            this.gbEmployeeDetails.Controls.Add(this.label6);
            this.gbEmployeeDetails.Controls.Add(this.label8);
            this.gbEmployeeDetails.Controls.Add(this.label4);
            this.gbEmployeeDetails.Controls.Add(this.tbSites);
            this.gbEmployeeDetails.Controls.Add(this.label2);
            this.gbEmployeeDetails.Controls.Add(this.label3);
            this.gbEmployeeDetails.Controls.Add(this.tbRemarks);
            this.gbEmployeeDetails.Controls.Add(this.tbProjectID);
            this.gbEmployeeDetails.Controls.Add(this.tbPartialPayment);
            this.gbEmployeeDetails.Controls.Add(this.tbCharges);
            this.gbEmployeeDetails.Controls.Add(this.tbDeliveredTo);
            this.gbEmployeeDetails.Controls.Add(this.tbControlNumber);
            this.gbEmployeeDetails.Font = new System.Drawing.Font("Poppins", 10F);
            this.gbEmployeeDetails.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbEmployeeDetails.Location = new System.Drawing.Point(20, 33);
            this.gbEmployeeDetails.Name = "gbEmployeeDetails";
            this.gbEmployeeDetails.Size = new System.Drawing.Size(756, 725);
            this.gbEmployeeDetails.TabIndex = 0;
            this.gbEmployeeDetails.TabStop = false;
            this.gbEmployeeDetails.Text = "Purchase Order";
            this.gbEmployeeDetails.Enter += new System.EventHandler(this.gbEmployeeDetails_Enter);
            // 
            // btnSavePurchaseOrder
            // 
            this.btnSavePurchaseOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSavePurchaseOrder.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSavePurchaseOrder.FlatAppearance.BorderSize = 0;
            this.btnSavePurchaseOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePurchaseOrder.Font = new System.Drawing.Font("Poppins", 10F);
            this.btnSavePurchaseOrder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSavePurchaseOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnSavePurchaseOrder.Image")));
            this.btnSavePurchaseOrder.Location = new System.Drawing.Point(281, 668);
            this.btnSavePurchaseOrder.Name = "btnSavePurchaseOrder";
            this.btnSavePurchaseOrder.Size = new System.Drawing.Size(111, 39);
            this.btnSavePurchaseOrder.TabIndex = 3;
            this.btnSavePurchaseOrder.Text = "Save";
            this.btnSavePurchaseOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSavePurchaseOrder.UseVisualStyleBackColor = false;
            this.btnSavePurchaseOrder.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEditRequester);
            this.groupBox1.Controls.Add(this.btnAddRequester);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lblRequesterID);
            this.groupBox1.Controls.Add(this.lblRequesterContact);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.lblRequesterName);
            this.groupBox1.Controls.Add(this.lblRequesterDesignation);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.lblPosition);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(419, 301);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 219);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Requester Information";
            // 
            // btnEditRequester
            // 
            this.btnEditRequester.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEditRequester.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditRequester.FlatAppearance.BorderSize = 0;
            this.btnEditRequester.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditRequester.Font = new System.Drawing.Font("Poppins", 8F);
            this.btnEditRequester.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditRequester.Location = new System.Drawing.Point(6, 189);
            this.btnEditRequester.Name = "btnEditRequester";
            this.btnEditRequester.Size = new System.Drawing.Size(110, 24);
            this.btnEditRequester.TabIndex = 3;
            this.btnEditRequester.Text = "Edit Requester";
            this.btnEditRequester.UseVisualStyleBackColor = false;
            this.btnEditRequester.Visible = false;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(51, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 23);
            this.label12.TabIndex = 4;
            this.label12.Text = "Requester ID:";
            // 
            // lblRequesterID
            // 
            this.lblRequesterID.AutoSize = true;
            this.lblRequesterID.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequesterID.Location = new System.Drawing.Point(164, 28);
            this.lblRequesterID.Name = "lblRequesterID";
            this.lblRequesterID.Size = new System.Drawing.Size(18, 23);
            this.lblRequesterID.TabIndex = 4;
            this.lblRequesterID.Text = "*";
            // 
            // lblRequesterContact
            // 
            this.lblRequesterContact.AutoSize = true;
            this.lblRequesterContact.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequesterContact.Location = new System.Drawing.Point(164, 141);
            this.lblRequesterContact.Name = "lblRequesterContact";
            this.lblRequesterContact.Size = new System.Drawing.Size(18, 23);
            this.lblRequesterContact.TabIndex = 4;
            this.lblRequesterContact.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(21, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(137, 23);
            this.label13.TabIndex = 4;
            this.label13.Text = "Requester Name:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(21, 141);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(137, 23);
            this.label15.TabIndex = 4;
            this.label15.Text = "Contact Number:";
            // 
            // lblRequesterName
            // 
            this.lblRequesterName.AutoSize = true;
            this.lblRequesterName.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequesterName.Location = new System.Drawing.Point(164, 55);
            this.lblRequesterName.Name = "lblRequesterName";
            this.lblRequesterName.Size = new System.Drawing.Size(18, 23);
            this.lblRequesterName.TabIndex = 4;
            this.lblRequesterName.Text = "*";
            // 
            // lblRequesterDesignation
            // 
            this.lblRequesterDesignation.AutoSize = true;
            this.lblRequesterDesignation.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequesterDesignation.Location = new System.Drawing.Point(164, 109);
            this.lblRequesterDesignation.Name = "lblRequesterDesignation";
            this.lblRequesterDesignation.Size = new System.Drawing.Size(18, 23);
            this.lblRequesterDesignation.TabIndex = 4;
            this.lblRequesterDesignation.Text = "*";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(56, 109);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(102, 23);
            this.label17.TabIndex = 4;
            this.label17.Text = "Designation:";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(164, 82);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(18, 23);
            this.lblPosition.TabIndex = 4;
            this.lblPosition.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(86, 82);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 23);
            this.label14.TabIndex = 4;
            this.label14.Text = "Position:";
            // 
            // gbSupplierInformation
            // 
            this.gbSupplierInformation.Controls.Add(this.btnEditSupplier);
            this.gbSupplierInformation.Controls.Add(this.btnAddSupplier);
            this.gbSupplierInformation.Controls.Add(this.label27);
            this.gbSupplierInformation.Controls.Add(this.lblSupplierID);
            this.gbSupplierInformation.Controls.Add(this.label16);
            this.gbSupplierInformation.Controls.Add(this.lblContactNumber);
            this.gbSupplierInformation.Controls.Add(this.lblAccountNumber);
            this.gbSupplierInformation.Controls.Add(this.lblSupplierAddress);
            this.gbSupplierInformation.Controls.Add(this.label24);
            this.gbSupplierInformation.Controls.Add(this.lblSupplierName);
            this.gbSupplierInformation.Controls.Add(this.label28);
            this.gbSupplierInformation.Controls.Add(this.label23);
            this.gbSupplierInformation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbSupplierInformation.Location = new System.Drawing.Point(419, 54);
            this.gbSupplierInformation.Name = "gbSupplierInformation";
            this.gbSupplierInformation.Size = new System.Drawing.Size(306, 224);
            this.gbSupplierInformation.TabIndex = 31;
            this.gbSupplierInformation.TabStop = false;
            this.gbSupplierInformation.Text = "Supplier Information";
            // 
            // btnEditSupplier
            // 
            this.btnEditSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEditSupplier.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEditSupplier.FlatAppearance.BorderSize = 0;
            this.btnEditSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditSupplier.Font = new System.Drawing.Font("Poppins", 8F);
            this.btnEditSupplier.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditSupplier.Location = new System.Drawing.Point(6, 187);
            this.btnEditSupplier.Name = "btnEditSupplier";
            this.btnEditSupplier.Size = new System.Drawing.Size(110, 24);
            this.btnEditSupplier.TabIndex = 3;
            this.btnEditSupplier.Text = "Edit Supplier";
            this.btnEditSupplier.UseVisualStyleBackColor = false;
            this.btnEditSupplier.Visible = false;
            this.btnEditSupplier.Click += new System.EventHandler(this.btnEditSupplier_Click);
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAddSupplier.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddSupplier.FlatAppearance.BorderSize = 0;
            this.btnAddSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSupplier.Font = new System.Drawing.Font("Poppins", 8F);
            this.btnAddSupplier.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddSupplier.Location = new System.Drawing.Point(210, 187);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(90, 24);
            this.btnAddSupplier.TabIndex = 3;
            this.btnAddSupplier.Text = "Add New";
            this.btnAddSupplier.UseVisualStyleBackColor = false;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // label27
            // 
            this.label27.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(65, 30);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(93, 23);
            this.label27.TabIndex = 4;
            this.label27.Text = "Supplier ID:";
            // 
            // lblSupplierID
            // 
            this.lblSupplierID.AutoSize = true;
            this.lblSupplierID.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierID.Location = new System.Drawing.Point(164, 30);
            this.lblSupplierID.Name = "lblSupplierID";
            this.lblSupplierID.Size = new System.Drawing.Size(18, 23);
            this.lblSupplierID.TabIndex = 4;
            this.lblSupplierID.Text = "*";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(83, 86);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 23);
            this.label16.TabIndex = 4;
            this.label16.Text = "Address:";
            // 
            // lblContactNumber
            // 
            this.lblContactNumber.AutoSize = true;
            this.lblContactNumber.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNumber.Location = new System.Drawing.Point(164, 142);
            this.lblContactNumber.Name = "lblContactNumber";
            this.lblContactNumber.Size = new System.Drawing.Size(18, 23);
            this.lblContactNumber.TabIndex = 4;
            this.lblContactNumber.Text = "*";
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountNumber.Location = new System.Drawing.Point(164, 114);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(18, 23);
            this.lblAccountNumber.TabIndex = 4;
            this.lblAccountNumber.Text = "*";
            // 
            // lblSupplierAddress
            // 
            this.lblSupplierAddress.AutoSize = true;
            this.lblSupplierAddress.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierAddress.Location = new System.Drawing.Point(164, 86);
            this.lblSupplierAddress.Name = "lblSupplierAddress";
            this.lblSupplierAddress.Size = new System.Drawing.Size(18, 23);
            this.lblSupplierAddress.TabIndex = 4;
            this.lblSupplierAddress.Text = "*";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(35, 58);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(123, 23);
            this.label24.TabIndex = 4;
            this.label24.Text = "Supplier Name:";
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierName.Location = new System.Drawing.Point(164, 58);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(18, 23);
            this.lblSupplierName.TabIndex = 4;
            this.lblSupplierName.Text = "*";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(21, 142);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(137, 23);
            this.label28.TabIndex = 4;
            this.label28.Text = "Contact Number:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Poppins Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(20, 114);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(138, 23);
            this.label23.TabIndex = 4;
            this.label23.Text = "Account Number:";
            // 
            // cbRequester
            // 
            this.cbRequester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRequester.FormattingEnabled = true;
            this.cbRequester.Location = new System.Drawing.Point(21, 165);
            this.cbRequester.Name = "cbRequester";
            this.cbRequester.Size = new System.Drawing.Size(371, 31);
            this.cbRequester.TabIndex = 29;
            this.cbRequester.SelectedIndexChanged += new System.EventHandler(this.cbRequester_SelectedIndexChanged);
            // 
            // cbModeOfPayment
            // 
            this.cbModeOfPayment.FormattingEnabled = true;
            this.cbModeOfPayment.Items.AddRange(new object[] {
            "Cash",
            "PDC",
            "Credit"});
            this.cbModeOfPayment.Location = new System.Drawing.Point(21, 389);
            this.cbModeOfPayment.Name = "cbModeOfPayment";
            this.cbModeOfPayment.Size = new System.Drawing.Size(371, 31);
            this.cbModeOfPayment.TabIndex = 29;
            // 
            // cbSupplierList
            // 
            this.cbSupplierList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSupplierList.FormattingEnabled = true;
            this.cbSupplierList.Location = new System.Drawing.Point(21, 106);
            this.cbSupplierList.Name = "cbSupplierList";
            this.cbSupplierList.Size = new System.Drawing.Size(371, 31);
            this.cbSupplierList.TabIndex = 29;
            this.cbSupplierList.SelectedIndexChanged += new System.EventHandler(this.cbSupplierList_SelectedIndexChanged);
            // 
            // dtpDateCreated
            // 
            this.dtpDateCreated.Location = new System.Drawing.Point(21, 499);
            this.dtpDateCreated.Name = "dtpDateCreated";
            this.dtpDateCreated.Size = new System.Drawing.Size(369, 27);
            this.dtpDateCreated.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poppins", 9F);
            this.label10.Location = new System.Drawing.Point(21, 477);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 22);
            this.label10.TabIndex = 4;
            this.label10.Text = "Date Created";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Poppins", 9F);
            this.label11.Location = new System.Drawing.Point(21, 200);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 22);
            this.label11.TabIndex = 4;
            this.label11.Text = "Site";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 9F);
            this.label7.Location = new System.Drawing.Point(17, 584);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 22);
            this.label7.TabIndex = 4;
            this.label7.Text = "Remarks";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Poppins", 9F);
            this.label18.Location = new System.Drawing.Point(17, 529);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 22);
            this.label18.TabIndex = 4;
            this.label18.Text = "Project ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 9F);
            this.label1.Location = new System.Drawing.Point(21, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Charges";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins", 9F);
            this.label9.Location = new System.Drawing.Point(21, 364);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 22);
            this.label9.TabIndex = 4;
            this.label9.Text = "Mode of Payment";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 9F);
            this.label6.Location = new System.Drawing.Point(21, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = "Partial Payment";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 9F);
            this.label8.Location = new System.Drawing.Point(21, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 22);
            this.label8.TabIndex = 4;
            this.label8.Text = "Requester";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 9F);
            this.label4.Location = new System.Drawing.Point(21, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Delivered to";
            // 
            // tbSites
            // 
            this.tbSites.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbSites.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbSites.Font = new System.Drawing.Font("Poppins", 9F);
            this.tbSites.Location = new System.Drawing.Point(21, 225);
            this.tbSites.Margin = new System.Windows.Forms.Padding(4);
            this.tbSites.Name = "tbSites";
            this.tbSites.Size = new System.Drawing.Size(370, 25);
            this.tbSites.TabIndex = 9;
            this.tbSites.TextChanged += new System.EventHandler(this.tbOperationalDays_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9F);
            this.label2.Location = new System.Drawing.Point(21, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Supplier";
            // 
            // tbRemarks
            // 
            this.tbRemarks.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbRemarks.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbRemarks.Font = new System.Drawing.Font("Poppins", 9F);
            this.tbRemarks.Location = new System.Drawing.Point(17, 610);
            this.tbRemarks.Margin = new System.Windows.Forms.Padding(4);
            this.tbRemarks.Multiline = true;
            this.tbRemarks.Name = "tbRemarks";
            this.tbRemarks.Size = new System.Drawing.Size(375, 51);
            this.tbRemarks.TabIndex = 6;
            this.tbRemarks.TextChanged += new System.EventHandler(this.tbOperationalDays_TextChanged);
            // 
            // tbProjectID
            // 
            this.tbProjectID.Font = new System.Drawing.Font("Poppins", 9F);
            this.tbProjectID.Location = new System.Drawing.Point(17, 555);
            this.tbProjectID.Margin = new System.Windows.Forms.Padding(4);
            this.tbProjectID.Name = "tbProjectID";
            this.tbProjectID.Size = new System.Drawing.Size(375, 25);
            this.tbProjectID.TabIndex = 2;
            this.tbProjectID.TextChanged += new System.EventHandler(this.tbOperationalDays_TextChanged);
            // 
            // tbPartialPayment
            // 
            this.tbPartialPayment.Font = new System.Drawing.Font("Poppins", 9F);
            this.tbPartialPayment.Location = new System.Drawing.Point(21, 335);
            this.tbPartialPayment.Margin = new System.Windows.Forms.Padding(4);
            this.tbPartialPayment.Name = "tbPartialPayment";
            this.tbPartialPayment.Size = new System.Drawing.Size(370, 25);
            this.tbPartialPayment.TabIndex = 5;
            // 
            // tbCharges
            // 
            this.tbCharges.Font = new System.Drawing.Font("Poppins", 9F);
            this.tbCharges.Location = new System.Drawing.Point(21, 448);
            this.tbCharges.Margin = new System.Windows.Forms.Padding(4);
            this.tbCharges.Name = "tbCharges";
            this.tbCharges.Size = new System.Drawing.Size(370, 25);
            this.tbCharges.TabIndex = 2;
            this.tbCharges.TextChanged += new System.EventHandler(this.tbOperationalDays_TextChanged);
            // 
            // tbDeliveredTo
            // 
            this.tbDeliveredTo.Font = new System.Drawing.Font("Poppins", 9F);
            this.tbDeliveredTo.Location = new System.Drawing.Point(21, 280);
            this.tbDeliveredTo.Margin = new System.Windows.Forms.Padding(4);
            this.tbDeliveredTo.Name = "tbDeliveredTo";
            this.tbDeliveredTo.Size = new System.Drawing.Size(370, 25);
            this.tbDeliveredTo.TabIndex = 4;
            this.tbDeliveredTo.TextChanged += new System.EventHandler(this.tbNonOperationalDays_TextChanged);
            // 
            // tbControlNumber
            // 
            this.tbControlNumber.Font = new System.Drawing.Font("Poppins", 9F);
            this.tbControlNumber.Location = new System.Drawing.Point(21, 54);
            this.tbControlNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tbControlNumber.Name = "tbControlNumber";
            this.tbControlNumber.ReadOnly = true;
            this.tbControlNumber.Size = new System.Drawing.Size(370, 25);
            this.tbControlNumber.TabIndex = 0;
            this.tbControlNumber.TextChanged += new System.EventHandler(this.tbNonOperationalDays_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Edit_Purchase_Order
            // 
            this.AcceptButton = this.btnAddRequester;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(786, 774);
            this.Controls.Add(this.gbEmployeeDetails);
            this.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Edit_Purchase_Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DomnPhil Purchasing - Edit Purchase Order";
            this.Load += new System.EventHandler(this.Employees_Load);
            this.gbEmployeeDetails.ResumeLayout(false);
            this.gbEmployeeDetails.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbSupplierInformation.ResumeLayout(false);
            this.gbSupplierInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddRequester;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbEmployeeDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbControlNumber;
        private System.Windows.Forms.TextBox tbCharges;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbRemarks;
        private System.Windows.Forms.TextBox tbPartialPayment;
        private System.Windows.Forms.TextBox tbDeliveredTo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbSites;
        private System.Windows.Forms.ComboBox cbSupplierList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDateCreated;
        private System.Windows.Forms.ComboBox cbRequester;
        private System.Windows.Forms.ComboBox cbModeOfPayment;
        private System.Windows.Forms.GroupBox gbSupplierInformation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblRequesterContact;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblRequesterName;
        private System.Windows.Forms.Label lblRequesterID;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lblSupplierID;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Label lblSupplierAddress;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblContactNumber;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button btnSavePurchaseOrder;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnEditRequester;
        private System.Windows.Forms.Label lblRequesterDesignation;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbProjectID;
        private System.Windows.Forms.Button btnEditSupplier;
    }
}

