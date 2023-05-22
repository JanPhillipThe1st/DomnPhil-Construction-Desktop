using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DomnPhil_Construction.Controller;
using Microsoft.Reporting.WinForms;
using System.Drawing.Printing;
using System.Globalization;

namespace DomnPhil_Construction.View
{
    public partial class PayrollPrinting : Form
    {
        DataGridView dgv = new DataGridView();
        Database database = new Database();
        String site = "",  month = "",  year = "";
        DateTime dateFrom = DateTime.Now, dateTo = DateTime.Now;
        double totalPayment = 0;

        private void btnLoad_Click(object sender, EventArgs e)
        {
            createReport();
        }

        public PayrollPrinting(ref DataGridView dgv, String month, String year, String site, DateTime dateFrom, DateTime dateTo, double totalPayment)
        {
            InitializeComponent();
            this.dgv = dgv;
            this.site = site;
            this.month = month;
            this.year = year;
            this.dateTo = dateTo;
            this.dateFrom = dateFrom;
            this.totalPayment = totalPayment;
        }

        private void PayrollPrinting_Load(object sender, EventArgs e)
        {
            createReport();
          
        }
        private void createReport() {

            this.reportViewer1.RefreshReport();
            reportViewer1.LocalReport.DataSources.Clear();

            ReportParameter month_name = new ReportParameter("month_name", this.month);
            ReportParameter date_from = new ReportParameter("date_from", dateFrom.ToString("MMMM dd"));
            ReportParameter date_to = new ReportParameter("date_to", dateTo.ToString("MMMM dd"));
            ReportParameter year = new ReportParameter("year", ", " + this.year.ToString());
            ReportParameter teamName = new ReportParameter("team_name", this.site);
            ReportParameter datePrinted = new ReportParameter("date_printed", DateTime.Now.ToString("MMMM dd, yyyy"));
            ReportParameter location = new ReportParameter("location", tbLocation.Text);
            ReportParameter total_payment = new ReportParameter("total_payment", totalPayment.ToString("n", CultureInfo.GetCultureInfo("en-PH")));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { month_name });
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { date_from });
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { date_to });
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { year });
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { teamName });
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { datePrinted });
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { location });
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { total_payment });
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Attendance", database.fillAttendanceReportTable(month, this.year, site)));
            this.reportViewer1.RefreshReport();
        }
    }
}
