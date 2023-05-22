using DomnPhil_Construction.Controller;
using DomnPhil_Construction.Models;
using DomnPhil_Construction.View;
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
    public partial class Employees : Form
    {
        Database db = new Database();
        Employee employee = new Employee();
        public Employees()
        {
            InitializeComponent();
        }

        private void btnTogglePasswordVisibilty_Click(object sender, EventArgs e)
        {
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            db.fillEmployeesTable(ref dgvEmployees);
            cbSites.Items.Clear();
            cbSites.Items.AddRange(db.getSiteList().ToArray());
        }

        private void tbSearchEmployee_TextChanged(object sender, EventArgs e)
        {
            db.searchEmployee(ref dgvEmployees,tbSearchEmployee.Text);
        }

        private void cbSites_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.filterEmployeesBySite(ref dgvEmployees,cbSites.Text);
        }

        private void dgvEmployees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
             employee = db.getEmployeeByID(dgvEmployees.SelectedCells[0].Value.ToString());
            new Edit_Employee(employee, "", "", dgvEmployees).Show();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            new Add_Employee(ref dgvEmployees).Show();
        }
    }
}
