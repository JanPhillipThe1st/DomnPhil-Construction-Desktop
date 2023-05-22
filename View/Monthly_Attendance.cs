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
    public partial class Monthly_Attendance : Form
    {
        Database db = new Database();
        public Monthly_Attendance()
        {
            InitializeComponent();
        }

        private void btnTogglePasswordVisibilty_Click(object sender, EventArgs e)
        {
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            db.fillMonthlyAttendanceTable(ref dgvEmployees);
        }

        private void tbSearchEmployee_TextChanged(object sender, EventArgs e)
        {
        }

        private void cbSites_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dgvEmployees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new EditEmployeeAttendance(dgvEmployees.SelectedCells[0].Value.ToString(), dgvEmployees.SelectedCells[3].Value.ToString(), Convert.ToDateTime( dgvEmployees.SelectedCells[1].Value.ToString()), Convert.ToDateTime(dgvEmployees.SelectedCells[2].Value)).Show();
        }

        private void btnGeneratePayroll_Click_1(object sender, EventArgs e)
        {
            new CreateMonthlyAttendance(ref dgvEmployees).Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?","",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                db.deleteAttendance(dgvEmployees.SelectedCells[0].Value.ToString(), dgvEmployees.SelectedCells[3].Value.ToString(), Convert.ToDateTime(dgvEmployees.SelectedCells[1].Value).ToString("yyyy-MM-dd"),Convert.ToDateTime( dgvEmployees.SelectedCells[2].Value).ToString("yyyy-MM-dd"));
                db.fillMonthlyAttendanceTable(ref dgvEmployees);
            }
        }
    }
}
