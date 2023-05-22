using DomnPhil_Construction.Controller;
using DomnPhil_Construction.Models;
using NCalc;
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
    public partial class Add_Employee : Form
    {
        Database db = new Database();
        Employee employee = new Employee();
        InputUtilities inputUtilities = new InputUtilities();
        DataGridView dgv = new DataGridView();
        double computedOperationalRate = 0;
        public Add_Employee(ref DataGridView dgv)
        {
            InitializeComponent();
            this.dgv = dgv;
        }

        private void btnTogglePasswordVisibilty_Click(object sender, EventArgs e)
        {
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            AutoCompleteStringCollection source = new AutoCompleteStringCollection();
            source.AddRange(db.getSiteList().ToArray());
            tbSite.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbSite.AutoCompleteCustomSource = source;
            
            AutoCompleteStringCollection designationSource = new AutoCompleteStringCollection();
            designationSource.AddRange(db.getDesignationList().ToArray());
            tbDesignation.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbDesignation.AutoCompleteCustomSource = designationSource;
            
            AutoCompleteStringCollection positionSource = new AutoCompleteStringCollection();
            positionSource.AddRange(db.getPositionList().ToArray());
            tbPosition.AutoCompleteSource = AutoCompleteSource.CustomSource;
            tbPosition.AutoCompleteCustomSource = positionSource;

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
            if (MessageBox.Show("Are you sure you want Add "+tbFullName.Text+"' ?", "Add "+tbFullName.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {

                    employee.control_number =  tbControlNumber.Text;
                    employee.last_name =  tbLastName.Text;
                    employee.first_name = tbFirstName.Text;
                    employee.name = tbFullName.Text;
                    employee.position = tbPosition.Text;
                    employee.designation = tbDesignation.Text;
                    employee.site = tbSite.Text;
                    employee.shop_rate = Convert.ToInt32(tbShopRate.Text);
                    employee.operational_rate = Convert.ToInt32(tbOperationalRate.Text);
                    if (cbRateCalculationType.Text.Contains("flat"))
                    {
                        employee.rate = employee.operational_rate;
                    }
                    else
                    {
                        employee.rate = 0;
                    }

                    db.addEmployee(employee);

                db.fillEmployeesTable(ref dgv);
                    this.Close();
                }
                catch (Exception ex )
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void tbOperationalDays_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnDeductibles_Click(object sender, EventArgs e)
        {
        }

        private void cbRateCalculationType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRateCalculationType.Text.Contains("flat"))
            {
                employee.rate = employee.operational_rate;
            }
            else {
                employee.rate = 0;
            }
        }

        private void tbLastName_TextChanged(object sender, EventArgs e)
        {
            tbFullName.Text = tbFirstName.Text + " " + tbLastName.Text;
        }

        private void tbOperationalRate_TextChanged(object sender, EventArgs e)
        {
                    
        
        }

        private void tbOperationalRate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (tbOperationalRate.Text[0] == '=')
                    {
                        var expression = new Expression(tbOperationalRate.Text.Substring(1));
                        var result = expression.Evaluate();
                        computedOperationalRate = Convert.ToDouble(result);
                        tbOperationalRate.Text = computedOperationalRate.ToString();
                        employee.operational_rate = (float)computedOperationalRate;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error in input expression.");
                }
            }
        }

        private void tbShopRate_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbShopRate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (tbShopRate.Text[0] == '=')
                    {
                        var expression = new Expression(tbShopRate.Text.Substring(1));
                        var result = expression.Evaluate();
                        computedOperationalRate = Convert.ToDouble(result);
                        tbShopRate.Text = computedOperationalRate.ToString();
                        employee.shop_rate = (float)computedOperationalRate;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error in input expression.");
                }
            }
        }
    }
}
