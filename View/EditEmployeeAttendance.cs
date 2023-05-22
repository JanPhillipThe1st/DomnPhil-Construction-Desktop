using DomnPhil_Construction.Controller;
using DomnPhil_Construction.Models;
using DomnPhil_Construction.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DomnPhil_Construction
{
    public partial class EditEmployeeAttendance : Form
    {
        Database db = new Database();
        String month = "";
        String year = "";
        DateTime dateFrom = DateTime.Now, dateTo = DateTime.Now;
        public EditEmployeeAttendance(String month, String year,DateTime dateFrom,DateTime dateTo)
        {
            InitializeComponent();
            this.month = month;
            this.year = year;
            this.dateFrom = dateFrom;
            this.dateTo = dateTo;
        }

        private void btnTogglePasswordVisibilty_Click(object sender, EventArgs e)
        {
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            lblMonth.Text = "Month: "+ month;
            lblYear.Text = "Year: " + year;
            db.fillAttendanceTable(ref dgvEmployees,month,year);
            lblWorkingDays.Text = "Working Days: "+ db.getWorkingDays(month,year).ToString();
            cbSites.Items.Clear();
            cbSites.Items.AddRange(db.getSiteList().ToArray());
            lblTotalPayment.Text = "Total Payment: "+ db.getPayrollTotal(ref dgvEmployees, month, year).ToString("n", CultureInfo.GetCultureInfo("en-PH"));
        }
        private void tbSearchEmployee_TextChanged(object sender, EventArgs e)
        {
            db.searchAttendanceTable(ref dgvEmployees, month, year,cbSites.Text,tbSearchEmployee.Text);
        }
        private void cbSites_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.fillAttendanceTable(ref dgvEmployees, month, year,cbSites.Text);
            lblTotalPayment.Text = "Total Payment: "+ db.getPayrollTotal(ref dgvEmployees, month, year, cbSites.Text).ToString("n", CultureInfo.GetCultureInfo("en-PH"));
        }

        private void dgvEmployees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Employee employee = db.getEmployeeByID(dgvEmployees.SelectedCells[0].Value.ToString());
            new Edit_Attendance(employee,month,year,dgvEmployees).Show();
        }

        private void btnGeneratePayroll_Click(object sender, EventArgs e)
        {
            if (cbSites.Text == "")
            {

            new PayrollPrinting(ref dgvEmployees, month, year, cbSites.Text,dateFrom,dateTo, db.getPayrollTotal(ref dgvEmployees, month, year)).Show();
            }
            else
            {
            new PayrollPrinting(ref dgvEmployees, month, year, cbSites.Text,dateFrom,dateTo, db.getPayrollTotal(ref dgvEmployees, month, year, cbSites.Text)).Show();

            }
        }

        private void bannerPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnGeneratePayslip_Click(object sender, EventArgs e)
        {
            if (cbSites.Text == "")
            {
                new PrintPayslip(ref dgvEmployees, month, year, cbSites.Text, dateFrom, dateTo, db.getPayrollTotal(ref dgvEmployees, month, year)).Show();
            }
            else { 
                new PrintPayslip(ref dgvEmployees, month, year, cbSites.Text, dateFrom, dateTo, db.getPayrollTotal(ref dgvEmployees, month, year,cbSites.Text)).Show();
            }
        }

        private void dgvEmployees_DataSourceChanged(object sender, EventArgs e)
        {
            lblTotalPayment.Text = "Total Payment: " + db.getPayrollTotal(ref dgvEmployees, month, year).ToString("n", CultureInfo.GetCultureInfo("en-PH"));
        }

        private void btnEditWorkingDays_Click(object sender, EventArgs e)
        {
            new WorkingDays(month,year,dgvEmployees).Show() ;
        }
    }
}
