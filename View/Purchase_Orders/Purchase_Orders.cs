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

namespace DomnPhil_Construction.View.Purchase_Orders
{
    public partial class Purchase_Orders : Form
    {
        Database db = new Database();
        public Purchase_Orders()
        {
            InitializeComponent();
        }

        private void Equipments_Load(object sender, EventArgs e)
        {
            db.fillPurchaseOrders(ref dgvPurchaseOrders);
            cbSites.Items.Clear();
            cbSites.Items.AddRange(db.getPurchaseOrderSiteList().ToArray());
        }

        private void tbSearchEmployee_TextChanged(object sender, EventArgs e)
        {
            db.searchPurchaseOrder(ref dgvPurchaseOrders, tbSearchEmployee.Text);
        }

        private void cbSites_SelectedIndexChanged(object sender, EventArgs e)
        {
            db.filterPurchaseOrdersBySite(ref dgvPurchaseOrders, cbSites.Text) ;
        }

      

        private void btnAddNewEquipment_Click(object sender, EventArgs e)
        {
            new Add_Purchase_Order(dgvPurchaseOrders).Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Purchase_Order purchase_order  = db.getPurchaseOrderByID(dgvPurchaseOrders.SelectedCells[0].Value.ToString());
            if (MessageBox.Show("Are you sure you want to delete purchase order '"+ purchase_order.control_number + "' ? ","Deleting data",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.deletePurchaseOrder(purchase_order.control_number);
                db.fillPurchaseOrders(ref dgvPurchaseOrders);
            }
        }

        private void gbEquipments_Enter(object sender, EventArgs e)
        {

        }

        private void dgvPurchaseOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Add some function for fetching purchase order data
            Purchase_Order purchase_order = db.getPurchaseOrderByID(dgvPurchaseOrders.SelectedCells[0].Value.ToString());
            //Might as well also handle adding of items in a purchase order.
            new Purchase_Order_Items(purchase_order).Show();
            //Might also as well implement CRUD

        }
    }
}
