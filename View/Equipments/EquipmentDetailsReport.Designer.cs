
namespace DomnPhil_Construction.View.Equipments
{
    partial class EquipmentDetailsReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EquipmentDetailsReport));
            this.equipmentDetailsReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // equipmentDetailsReportViewer
            // 
            this.equipmentDetailsReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equipmentDetailsReportViewer.LocalReport.ReportEmbeddedResource = "DomnPhil_Construction.Reporting.EquipmentDetailsReport.rdlc";
            this.equipmentDetailsReportViewer.Location = new System.Drawing.Point(0, 0);
            this.equipmentDetailsReportViewer.Name = "equipmentDetailsReportViewer";
            this.equipmentDetailsReportViewer.ServerReport.BearerToken = null;
            this.equipmentDetailsReportViewer.Size = new System.Drawing.Size(1420, 703);
            this.equipmentDetailsReportViewer.TabIndex = 0;
            // 
            // EquipmentDetailsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 703);
            this.Controls.Add(this.equipmentDetailsReportViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EquipmentDetailsReport";
            this.Text = "DomnPhil Construction - Equipment Details";
            this.Load += new System.EventHandler(this.EquipmentDetailsReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer equipmentDetailsReportViewer;
    }
}