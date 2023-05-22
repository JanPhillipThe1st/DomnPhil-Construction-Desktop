
namespace DomnPhil_Construction.View.Equipments
{
    partial class EquipmentListPrinting
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
            this.equipmentReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // equipmentReport
            // 
            this.equipmentReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equipmentReport.LocalReport.ReportEmbeddedResource = "DomnPhil_Construction.Reporting.EquipmentList.rdlc";
            this.equipmentReport.Location = new System.Drawing.Point(0, 0);
            this.equipmentReport.Name = "equipmentReport";
            this.equipmentReport.ServerReport.BearerToken = null;
            this.equipmentReport.Size = new System.Drawing.Size(1334, 647);
            this.equipmentReport.TabIndex = 0;
            this.equipmentReport.Load += new System.EventHandler(this.equipmentReport_Load);
            // 
            // EquipmentListPrinting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 647);
            this.Controls.Add(this.equipmentReport);
            this.Name = "EquipmentListPrinting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DomnPhil Construction - Equipment List Report";
            this.Load += new System.EventHandler(this.EquipmentListPrinting_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer equipmentReport;
    }
}