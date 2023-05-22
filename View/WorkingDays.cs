using DomnPhil_Construction.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DomnPhil_Construction
{
    public partial class WorkingDays : Form
    {
        bool showPassword = false;
        private Panel bannerPanel;
        private GroupBox gbEmployeeDetails;
        private Button btnSave;
        private TextBox tbWorkingDays;
        private Label label3;
        private Label lblMonth;
        DataGridView dgv = new DataGridView();
        private Label lblYear;
        Database db = new Database();
        String month = "", year = "";
        public WorkingDays(String month, String year, DataGridView dgv)
        {
            InitializeComponent();
            this.month = month;
            this.year = year;
            this.dgv = dgv;
        }

        private void btnTogglePasswordVisibilty_Click(object sender, EventArgs e)
        {
          
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
          
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            db.editWorkingDays(month,year,Convert.ToInt32(tbWorkingDays.Text));
            db.fillAttendanceTable(ref dgv,month,year);
        }

        private void WorkingDays_Load(object sender, EventArgs e)
        {
            lblMonth.Text = "Month: "+ month;
            lblYear.Text = "Year: "+ year;
            tbWorkingDays.Text = db.getWorkingDays(month, year).ToString();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkingDays));
            this.bannerPanel = new System.Windows.Forms.Panel();
            this.gbEmployeeDetails = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbWorkingDays = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbEmployeeDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // bannerPanel
            // 
            this.bannerPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bannerPanel.BackgroundImage")));
            this.bannerPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bannerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.bannerPanel.Location = new System.Drawing.Point(0, 0);
            this.bannerPanel.Margin = new System.Windows.Forms.Padding(4);
            this.bannerPanel.Name = "bannerPanel";
            this.bannerPanel.Size = new System.Drawing.Size(421, 69);
            this.bannerPanel.TabIndex = 1;
            // 
            // gbEmployeeDetails
            // 
            this.gbEmployeeDetails.Controls.Add(this.btnSave);
            this.gbEmployeeDetails.Controls.Add(this.tbWorkingDays);
            this.gbEmployeeDetails.Controls.Add(this.lblYear);
            this.gbEmployeeDetails.Controls.Add(this.lblMonth);
            this.gbEmployeeDetails.Controls.Add(this.label3);
            this.gbEmployeeDetails.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEmployeeDetails.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbEmployeeDetails.Location = new System.Drawing.Point(16, 76);
            this.gbEmployeeDetails.Name = "gbEmployeeDetails";
            this.gbEmployeeDetails.Size = new System.Drawing.Size(393, 256);
            this.gbEmployeeDetails.TabIndex = 7;
            this.gbEmployeeDetails.TabStop = false;
            this.gbEmployeeDetails.Text = "Working Days";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Poppins", 10F);
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Location = new System.Drawing.Point(260, 176);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 28);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbWorkingDays
            // 
            this.tbWorkingDays.Font = new System.Drawing.Font("Poppins", 9F);
            this.tbWorkingDays.Location = new System.Drawing.Point(22, 144);
            this.tbWorkingDays.Margin = new System.Windows.Forms.Padding(4);
            this.tbWorkingDays.Name = "tbWorkingDays";
            this.tbWorkingDays.Size = new System.Drawing.Size(352, 25);
            this.tbWorkingDays.TabIndex = 5;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Poppins", 10F);
            this.lblYear.Location = new System.Drawing.Point(19, 69);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(46, 25);
            this.lblYear.TabIndex = 4;
            this.lblYear.Text = "Year:";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Poppins", 10F);
            this.lblMonth.Location = new System.Drawing.Point(19, 34);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(59, 25);
            this.lblMonth.TabIndex = 4;
            this.lblMonth.Text = "Month:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 10F);
            this.label3.Location = new System.Drawing.Point(19, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Working Days";
            // 
            // WorkingDays
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(421, 346);
            this.Controls.Add(this.gbEmployeeDetails);
            this.Controls.Add(this.bannerPanel);
            this.Name = "WorkingDays";
            this.Text = "Working Days";
            this.Load += new System.EventHandler(this.WorkingDays_Load);
            this.gbEmployeeDetails.ResumeLayout(false);
            this.gbEmployeeDetails.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
