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

namespace DomnPhil_Construction.View.Equipments
{
    public partial class Equipments : Form
    {
        Database db = new Database();
        public Equipments()
        {
            InitializeComponent();
        }

        private void Equipments_Load(object sender, EventArgs e)
        {
            db.fillEquipmentsTable(ref dgvEquipments);
            cbSites.Items.Clear();
            cbSites.Items.AddRange(db.getEquipmentSiteList().ToArray());
            lblCount.Text = "Total Equipments :  "+dgvEquipments.Rows.Count;
        }

        private void tbSearchEmployee_TextChanged(object sender, EventArgs e)
        {
            db.searchEquipment(ref dgvEquipments, tbSearchEmployee.Text);
        }

        private void cbSites_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.filterEquipmentsBySite(ref dgvEquipments, cbSites.Text) ;
            if (cbSites.Text == "")
            {
                lblCount.Text = "Total Equipments :  " + dgvEquipments.Rows.Count;
            }
            else { 
            lblCount.Text = "Equipments in "+ cbSites.Text+" :  " + dgvEquipments.Rows.Count;
            
            }
        }

        private void dgvEquipments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
         Equipment equipment =   db.getEquipmentByControlNumber(dgvEquipments.SelectedCells[0].Value.ToString());
            new Edit_Equipment(equipment, dgvEquipments).Show() ;
        }

        private void btnAddNewEquipment_Click(object sender, EventArgs e)
        {
            new Add_Equipment(dgvEquipments).Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Equipment equipment = db.getEquipmentByControlNumber(dgvEquipments.SelectedCells[0].Value.ToString());
            if (MessageBox.Show("Are you sure you want to delete Equipment "+equipment.control_number+" ?","",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                db.deleteEquipment(equipment);
                db.fillEquipmentsTable(ref dgvEquipments);
            }
        }

        private void btnEquipmentRepair_Click(object sender, EventArgs e)
        {
            new Repair_Records().Show();
        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            new EquipmentListPrinting().Show();
        }
    }
}
