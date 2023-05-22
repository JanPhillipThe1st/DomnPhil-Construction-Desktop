
namespace DomnPhil_Construction.View.Equipments
{
    partial class ViewEquipmentPhoto
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
            this.pbEquipmentPhoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbEquipmentPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pbEquipmentPhoto
            // 
            this.pbEquipmentPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbEquipmentPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbEquipmentPhoto.Location = new System.Drawing.Point(0, 0);
            this.pbEquipmentPhoto.Name = "pbEquipmentPhoto";
            this.pbEquipmentPhoto.Size = new System.Drawing.Size(974, 682);
            this.pbEquipmentPhoto.TabIndex = 0;
            this.pbEquipmentPhoto.TabStop = false;
            // 
            // ViewEquipmentPhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 682);
            this.Controls.Add(this.pbEquipmentPhoto);
            this.Name = "ViewEquipmentPhoto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DomnPhil Construction - View Equipment Photo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ViewEquipmentPhoto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbEquipmentPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbEquipmentPhoto;
    }
}