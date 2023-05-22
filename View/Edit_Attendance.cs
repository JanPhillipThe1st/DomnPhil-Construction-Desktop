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
    public partial class Edit_Attendance : Form
    {
        Database db = new Database();
        Employee employee = new Employee();
        InputUtilities inputUtilities = new InputUtilities();
        DataGridView dgv = new DataGridView();
        String month = "";
        String year = "";
        public Edit_Attendance(Employee employee, String month,String year, DataGridView dgv)
        {
            InitializeComponent();
            this.employee = employee;
            this.month = month;
            this.year = year;
            this.dgv = dgv;
        }

        private void btnTogglePasswordVisibilty_Click(object sender, EventArgs e)
        {
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            tbAbsences.Text = employee.absent.ToString();
            tbOperationalDays.Text = db.getWorkingDays(month, year).ToString();
            tbNonOperationalDays.Text = employee.breakdown_days_present.ToString();
            tbOverimeHours.Text = employee.overtime_hours.ToString();
            tbUndertime.Text = employee.undertime_hours.ToString();

        }

        private void tbSearchEmployee_TextChanged(object sender, EventArgs e)
        {
        }

        private void cbSites_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dgvEmployees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to save this information?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    employee.breakdown_days_present = Convert.ToDouble(tbNonOperationalDays.Text);
                    employee.operation_days_present = Convert.ToDouble(tbOperationalDays.Text);
                    employee.absent = Convert.ToDouble(tbAbsences.Text);
                    employee.overtime_hours = Convert.ToDouble(tbOverimeHours.Text);
                    employee.undertime_hours = Convert.ToDouble(tbUndertime.Text);
                    db.editEmployeeAttendance(employee,month,year);

                db.fillAttendanceTable(ref dgv, month, year);

                }
                catch (Exception ex )
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void tbNonOperationalDays_TextChanged(object sender, EventArgs e)
        {
            if (inputUtilities.isDouble(tbNonOperationalDays.Text))
            {
                employee.breakdown_days_present = Convert.ToDouble(tbNonOperationalDays.Text);
            }
            else
            {
                tbNonOperationalDays.Clear();
            }
        }

        private void tbOperationalDays_TextChanged(object sender, EventArgs e)
        {
            if (inputUtilities.isDouble(tbOperationalDays.Text))
            {
                employee.operation_days_present = Convert.ToDouble(tbOperationalDays.Text);
            }
            else
            {
                tbOperationalDays.Clear();
            }
        }

        private void tbAbsences_TextChanged(object sender, EventArgs e)
        {
            if (inputUtilities.isDouble(tbAbsences.Text))
            {
                employee.absent = Convert.ToDouble(tbAbsences.Text);
            }
            else
            {
                tbAbsences.Clear();
            }
        }

        private void btnDeductibles_Click(object sender, EventArgs e)
        {
            new Deductibles(employee,month,year,dgv).Show();
        }
    }
}
