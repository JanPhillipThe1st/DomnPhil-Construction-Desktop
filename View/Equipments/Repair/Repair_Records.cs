using DomnPhil_Construction.Controller;
using DomnPhil_Construction.Models;
using DomnPhil_Construction.View.Suppliers;
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
    public partial class Repair_Records : Form
    {
        Database db = new Database();
        Equipment equipment = new Equipment();
        InputUtilities inputUtilities = new InputUtilities();
        Dictionary<String, String> suppliers = new Dictionary<String, String>();
        Dictionary<String, String> requesters = new Dictionary<String, String>();
        public Repair_Records()
        {
            InitializeComponent();
        }

        private void btnTogglePasswordVisibilty_Click(object sender, EventArgs e)
        {
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            db.fillRepairTable(dgvPurchaseOrders);
            autofillValues();
        }

        private void tbSearchEmployee_TextChanged(object sender, EventArgs e)
        {
        }
        private void autofillValues()
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
            if (inputUtilities.completelyFilled(gbEmployeeDetails, errorProvider1))
            {
                if (MessageBox.Show("Are you sure you want to save this record?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                 
                    try
                    {
                    }
                    catch (FormatException ex)
                    {
                    }

                }
            }
        }

        private void tbNonOperationalDays_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbOperationalDays_TextChanged(object sender, EventArgs e)
        {

        }



        private void btnDeductibles_Click(object sender, EventArgs e)
        {

        }

        private void cbRateCalculationType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {

        }

        private void gbEmployeeDetails_Enter(object sender, EventArgs e)
        {

        }

        private void tbEquipmentPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbCertificateOfRegistrationPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
        }

        private void btnAddRequester_Click(object sender, EventArgs e)
        {
        }

        private void cbSupplierList_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cbRequester_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gbSupplierInformation_Enter(object sender, EventArgs e)
        {

        }
    }
}
