using DomnPhil_Construction.Controller;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DomnPhil_Construction.View
{
    public partial class PrintPayslip : Form
    {
        DataGridView dgv = new DataGridView();
        Database database = new Database();
        String site = "", month = "", year = "";
        DateTime dateFrom = DateTime.Now, dateTo = DateTime.Now;
        double totalPayment = 0;
        public PrintPayslip(ref DataGridView dgv, String month, String year, String site, DateTime dateFrom, DateTime dateTo, double totalPayment)
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

        private void PrintPayslip_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            reportViewer1.LocalReport.DataSources.Clear();
            ReportParameter month_name = new ReportParameter("month_name", this.month);
            ReportParameter date_from = new ReportParameter("date_from", dateFrom.ToString("MMMM dd"));
            ReportParameter date_to = new ReportParameter("date_to", dateTo.ToString("MMMM dd"));
            ReportParameter year = new ReportParameter("year", ", " + this.year.ToString());
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { month_name });
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { date_from });
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { date_to });
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { year });
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Attendance", database.fillAttendanceReportTable(month, this.year, site)));
            this.reportViewer1.RefreshReport();

        }
    }
}
