
namespace DomnPhil_Construction.View.Suppliers
{
    partial class Edit_Requester
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
            this.gbSupplierInformation = new System.Windows.Forms.GroupBox();
            this.tbDesignation = new System.Windows.Forms.TextBox();
            this.tbContactNumber = new System.Windows.Forms.TextBox();
            this.tbPosition = new System.Windows.Forms.TextBox();
            this.tbRequesterName = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.gbSupplierInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSupplierInformation
            // 
            this.gbSupplierInformation.Controls.Add(this.tbDesignation);
            this.gbSupplierInformation.Controls.Add(this.tbContactNumber);
            this.gbSupplierInformation.Controls.Add(this.tbPosition);
            this.gbSupplierInformation.Controls.Add(this.tbRequesterName);
            this.gbSupplierInformation.Controls.Add(this.btnDelete);
            this.gbSupplierInformation.Controls.Add(this.btnSave);
            this.gbSupplierInformation.Controls.Add(this.label16);
            this.gbSupplierInformation.Controls.Add(this.label24);
            this.gbSupplierInformation.Controls.Add(this.label1);
            this.gbSupplierInformation.Controls.Add(this.label28);
            this.gbSupplierInformation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbSupplierInformation.Location = new System.Drawing.Point(18, 25);
            this.gbSupplierInformation.Name = "gbSupplierInformation";
            this.gbSupplierInformation.Size = new System.Drawing.Size(418, 333);
            this.gbSupplierInformation.TabIndex = 0;
            this.gbSupplierInformation.TabStop = false;
            this.gbSupplierInformation.Text = "Requester Information";
            // 
            // tbDesignation
            // 
            this.tbDesignation.Font = new System.Drawing.Font("Poppins", 9F);
            this.tbDesignation.Location = new System.Drawing.Point(24, 243);
            this.tbDesignation.Margin = new System.Windows.Forms.Padding(4);
            this.tbDesignation.Name = "tbDesignation";
            this.tbDesignation.Size = new System.Drawing.Size(370, 25);
            this.tbDesignation.TabIndex = 5;
            // 
            // tbContactNumber
            // 
            this.tbContactNumber.Font = new System.Drawing.Font("Poppins", 9F);
            this.tbContactNumber.Location = new System.Drawing.Point(24, 187);
            this.tbContactNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tbContactNumber.Name = "tbContactNumber";
            this.tbContactNumber.Size = new System.Drawing.Size(370, 25);
            this.tbContactNumber.TabIndex = 4;
            // 
            // tbPosition
            // 
            this.tbPosition.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.tbPosition.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbPosition.Font = new System.Drawing.Font("Poppins", 9F);
            this.tbPosition.Location = new System.Drawing.Point(24, 131);
            this.tbPosition.Margin = new System.Windows.Forms.Padding(4);
            this.tbPosition.Name = "tbPosition";
            this.tbPosition.Size = new System.Drawing.Size(370, 25);
            this.tbPosition.TabIndex = 2;
            // 
            // tbRequesterName
            // 
            this.tbRequesterName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.tbRequesterName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbRequesterName.Font = new System.Drawing.Font("Poppins", 9F);
            this.tbRequesterName.Location = new System.Drawing.Point(24, 71);
            this.tbRequesterName.Margin = new System.Windows.Forms.Padding(4);
            this.tbRequesterName.Name = "tbRequesterName";
            this.tbRequesterName.Size = new System.Drawing.Size(370, 25);
            this.tbRequesterName.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Poppins", 10F);
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(24, 275);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 31);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Poppins", 10F);
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Location = new System.Drawing.Point(284, 275);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 31);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(20, 100);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 23);
            this.label16.TabIndex = 1;
            this.label16.Text = "Position:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(20, 44);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(121, 23);
            this.label24.TabIndex = 4;
            this.label24.Text = "Requester Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Designation:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(20, 160);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(121, 23);
            this.label28.TabIndex = 3;
            this.label28.Text = "Contact Number:";
            // 
            // Edit_Requester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(455, 385);
            this.Controls.Add(this.gbSupplierInformation);
            this.Font = new System.Drawing.Font("Poppins", 10F);
            this.Name = "Edit_Requester";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Domnphil Purchasing - Add Requester";
            this.Load += new System.EventHandler(this.Add_Requester_Load);
            this.gbSupplierInformation.ResumeLayout(false);
            this.gbSupplierInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSupplierInformation;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox tbContactNumber;
        private System.Windows.Forms.TextBox tbPosition;
        private System.Windows.Forms.TextBox tbRequesterName;
        private System.Windows.Forms.TextBox tbDesignation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
    }
}