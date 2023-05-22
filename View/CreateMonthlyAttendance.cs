using DomnPhil_Construction.Controller;
using DomnPhil_Construction.Models;
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
    public partial class CreateMonthlyAttendance : Form
    {
        Database db = new Database();
        Employee employee = new Employee();
        InputUtilities inputUtilities = new InputUtilities();
        DataGridView dgv = new DataGridView();
        public CreateMonthlyAttendance(ref DataGridView dgv)
        {
            InitializeComponent();
            this.dgv = dgv;
        }

        private void CreateMonthlyAttendance_Load(object sender, EventArgs e)
        {
            String[] monthNameArray = {"January","February","March","April","May","June","July"
            ,"August","September","October","November","December"};
            cbMonth.Items.AddRange(monthNameArray);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to create this record?","",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MonthlyAttendance monthlyAttendance = new MonthlyAttendance();
                monthlyAttendance.month = cbMonth.Text;
                monthlyAttendance.dateFrom = dtpFrom.Value;
                monthlyAttendance.days_present = Convert.ToInt32(tbWorkingDays.Text);
                monthlyAttendance.dateTo = dtpTo.Value;
                monthlyAttendance.year = dtpTo.Value.Year;
                monthlyAttendance.working_days = Convert.ToInt32(tbWorkingDays.Text);
                foreach (Employee  employee in db.GetEmployees())
                {
                    db.createMonthlyAttendance(employee,monthlyAttendance);
                }
                MessageBox.Show("Record successfully created!");
                db.fillMonthlyAttendanceTable(ref dgv);
            }
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            
            tbWorkingDays.Text =    GetBusinessDays(dtpFrom.Value,dtpTo.Value).ToString();
        }
        public static double GetBusinessDays(DateTime startD, DateTime endD)
        {
            double calcBusinessDays =
                1 + ((endD - startD).TotalDays * 5 -
                (startD.DayOfWeek - endD.DayOfWeek) * 2) / 7;

            if (endD.DayOfWeek == DayOfWeek.Saturday) calcBusinessDays--;
            if (startD.DayOfWeek == DayOfWeek.Sunday) calcBusinessDays--;

            return calcBusinessDays;
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            tbWorkingDays.Text =    GetBusinessDays(dtpFrom.Value,dtpTo.Value).ToString();
        }
    }
}
