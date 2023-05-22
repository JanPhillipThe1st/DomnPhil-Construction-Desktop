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
    public partial class Deductibles : Form
    {
        Database db = new Database();
        Employee employee = new Employee();
        InputUtilities inputUtilities = new InputUtilities();
        DataGridView dgv = new DataGridView();
        String month = "";
        String year = "";
        public Deductibles(Employee employee, String month,String year, DataGridView dgv)
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
            lblEmployeeName.Text = "Employee: "+employee.name;
            tbSSS.Text = employee.absent.ToString();
            tbPagIbig.Text = employee.operation_days_present.ToString();
            tbCashAdvance.Text = employee.breakdown_days_present.ToString();
            tbPhilHealth.Text = employee.overtime_hours.ToString();

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
            if (inputUtilities.isDouble(tbCashAdvance.Text)) {
                errorProvider1.SetError(tbCashAdvance,"Missing or incorrect value");
            }
            else if (inputUtilities.isDouble(tbLoan.Text)) { 
                errorProvider1.SetError(tbLoan, "Missing or incorrect value");
            
            } else if (inputUtilities.isDouble(tbSSS.Text) ) { 
                errorProvider1.SetError(tbSSS, "Missing or incorrect value");
            
            }else if (inputUtilities.isDouble(tbPagIbig.Text)) { 
                errorProvider1.SetError(tbPagIbig, "Missing or incorrect value");
            
            }else if (inputUtilities.isDouble(tbPhilHealth.Text)) { 
                errorProvider1.SetError(tbPhilHealth, "Missing or incorrect value");
            
            }else if (inputUtilities.isDouble(tbMonthEndCashAdvance.Text)) { 
                errorProvider1.SetError(tbMonthEndCashAdvance, "Missing or incorrect value");
            
            }
                if (MessageBox.Show("Are you sure you want to save this information?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (inputUtilities.isDouble(tbCashAdvance.Text) && inputUtilities.isDouble(tbLoan.Text) && inputUtilities.isDouble(tbSSS.Text) && inputUtilities.isDouble(tbPagIbig.Text) && inputUtilities.isDouble(tbPhilHealth.Text) && inputUtilities.isDouble(tbMonthEndCashAdvance.Text))
                {
                    employee.cash_advance = Convert.ToDouble(tbCashAdvance.Text);
                    employee.loan = Convert.ToDouble(tbLoan.Text);
                    employee.sss = Convert.ToDouble(tbSSS.Text);
                    employee.pag_ibig = Convert.ToDouble(tbPagIbig.Text);
                    employee.philhealth = Convert.ToDouble(tbPhilHealth.Text);
                    employee.month_end_cash_advance = Convert.ToDouble(tbMonthEndCashAdvance.Text);


                    db.updateDeductibles(employee, month, year);
                    db.fillAttendanceTable(ref dgv, month, year);
                }
                else
                {
                    tbCashAdvance.Clear();
                    tbLoan.Clear();
                    tbPagIbig.Clear();
                    tbPhilHealth.Clear();
                    tbMonthEndCashAdvance.Clear();
                }
            }
        }


        private void tbOperationalDays_TextChanged(object sender, EventArgs e)
        {
            if (inputUtilities.isInteger(tbCashAdvance.Text))
            {
                employee.operation_days_present = Convert.ToInt32(tbPagIbig.Text);
            }
            else
            {
                tbPagIbig.Clear();
            }
        }

        private void tbAbsences_TextChanged(object sender, EventArgs e)
        {
            if (inputUtilities.isInteger(tbSSS.Text))
            {
                employee.absent = Convert.ToInt32(tbSSS.Text);
            }
            else
            {
                tbSSS.Clear();
            }
        }
    }
}
