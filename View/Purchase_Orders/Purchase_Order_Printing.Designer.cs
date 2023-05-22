
namespace DomnPhil_Construction.View.Purchase_Orders
{
    partial class Purchase_Order_Printing
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
            this.purchaseOrderReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // purchaseOrderReport
            // 
            this.purchaseOrderReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.purchaseOrderReport.LocalReport.ReportEmbeddedResource = "DomnPhil_Construction.Reporting.Purchase_order_printable.rdlc";
            this.purchaseOrderReport.Location = new System.Drawing.Point(0, 0);
            this.purchaseOrderReport.Name = "purchaseOrderReport";
            this.purchaseOrderReport.ServerReport.BearerToken = null;
            this.purchaseOrderReport.Size = new System.Drawing.Size(1110, 628);
            this.purchaseOrderReport.TabIndex = 0;
            this.purchaseOrderReport.Load += new System.EventHandler(this.purchaseOrderReport_Load);
            // 
            // Purchase_Order_Printing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 628);
            this.Controls.Add(this.purchaseOrderReport);
            this.Name = "Purchase_Order_Printing";
            this.Text = "Domnphil Construction - Purchase Order Printing";
            this.Load += new System.EventHandler(this.Purchase_Order_Printing_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer purchaseOrderReport;
    }
}