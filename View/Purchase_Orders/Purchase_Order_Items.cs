using DomnPhil_Construction.Controller;
using DomnPhil_Construction.Models;
using DomnPhil_Construction.View.Purchase_Orders;
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
    public partial class Purchase_Order_Items : Form
    {
        Database db = new Database();
        Equipment equipment = new Equipment();
        Models.Purchase_Order purchase_order = new Purchase_Order();
        InputUtilities inputUtilities = new InputUtilities();
        DataGridView dgv = new DataGridView();
        Dictionary<String, String> suppliers = new Dictionary<String, String>();
        Dictionary<String, String> requesters = new Dictionary<String, String>();
        public Purchase_Order_Items(Models.Purchase_Order purchase_order)
        {
            InitializeComponent();
            this.purchase_order = purchase_order;
        }
        //Add Function for editing/deleting an item in the purchase order
        //Might as well add a refresh function for every change in the purchase item data
        private void btnTogglePasswordVisibilty_Click(object sender, EventArgs e)
        {
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            lblTableLabel.Text = "Items in purchase order: " + purchase_order.control_number;
            db.fillPurchaseOrderItems(purchase_order.control_number, dgvPurchaseOrderItems);
            dgvPurchaseOrderItems.Columns[8].Visible = false;
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
            try
            {
                Purchase_Order_Item PO_item = new Purchase_Order_Item();
                PO_item.purchase_order = purchase_order.control_number;
                PO_item.quantity = int.Parse(tbQuantity.Text);
                PO_item.unit = tbUnit.Text;
                PO_item.description = tbDescription.Text;
                PO_item.unit_cost = Double.Parse(tbUnitCost.Text);
                PO_item.discount = Double.Parse(tbDiscount.Text);
                PO_item.amount = Double.Parse(tbTotalAmount.Text);


                db.addPurchaseOrderItem(PO_item);
                db.fillPurchaseOrderItems(purchase_order.control_number, dgvPurchaseOrderItems);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please input all the fields properly.");
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

        private void tbUnitCost_TextChanged(object sender, EventArgs e)
        {

            try
            {

                tbTotalAmount.Text = ((Double.Parse(tbUnitCost.Text) * Double.Parse(tbQuantity.Text)) - Double.Parse(tbDiscount.Text)).ToString();
            }
            catch (Exception ex)
            {
            }
        }

        private void tbQuantity_TextChanged(object sender, EventArgs e)
        {
            try
            {

                tbTotalAmount.Text = ((Double.Parse(tbUnitCost.Text) * Double.Parse(tbQuantity.Text)) - Double.Parse(tbDiscount.Text)).ToString();
            }
            catch (Exception ex)
            {
            }
        }

        private void tbDiscount_TextChanged(object sender, EventArgs e)
        {
            try
            {

                tbTotalAmount.Text = ((Double.Parse(tbUnitCost.Text) * Double.Parse(tbQuantity.Text)) - Double.Parse(tbDiscount.Text)).ToString();
            }
            catch (Exception ex)
            {
            }
        }

        private void dgvPurchaseOrderItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPurchaseOrderItems_DataSourceChanged(object sender, EventArgs e)
        {
            Double purchaseOrderTotal = 0;
            foreach (DataGridViewRow row in dgvPurchaseOrderItems.Rows)
            {
              purchaseOrderTotal +=  Double.Parse(row.Cells[8].Value.ToString());
            }
            lblPurchaseOrderTotal.Text = "Purchase Order Total: PHP " + String.Format( "{0:#,###.##0}",purchaseOrderTotal);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            new Purchase_Order_Printing(purchase_order).Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            new Edit_Purchase_Order(purchase_order).Show();
        }
    }
}

