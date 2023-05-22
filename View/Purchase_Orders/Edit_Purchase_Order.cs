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
    public partial class Edit_Purchase_Order : Form
    {
        Database db = new Database();
        Equipment equipment = new Equipment();
        Models.Purchase_Order purchase_order = new Purchase_Order();
        InputUtilities inputUtilities = new InputUtilities();
        DataGridView dgv = new DataGridView();
        Models.Supplier supplier = new Supplier();
        Models.Requester requester = new Requester();
        Dictionary<String, String> suppliers = new Dictionary<String, String>();
        Dictionary<String, String> requesters = new Dictionary<String, String>();
        public Edit_Purchase_Order(Models.Purchase_Order purchase_order)
        {
            InitializeComponent();
            this.purchase_order = purchase_order;
        }

        private void btnTogglePasswordVisibilty_Click(object sender, EventArgs e)
        {
        }

        private void Employees_Load(object sender, EventArgs e)
        {

            fillPurchaseOrderInformation();
            autofillValues();
        }
        private void fillPurchaseOrderInformation() {
            supplier = db.getSupplierByID(purchase_order.supplier_id);
            requester = db.getRequesterByID(purchase_order.requester_id);

            cbRequester.Text = requester.requester_name;
            cbSupplierList.Text = supplier.supplier_name;
            tbControlNumber.Text = purchase_order.control_number;
            tbSites.Text = purchase_order.site;
            tbDeliveredTo.Text = purchase_order.delivered_to;
            tbPartialPayment.Text = purchase_order.partial_payment.ToString();
            cbModeOfPayment.Text = purchase_order.mode_of_payment;
            tbCharges.Text = purchase_order.charges;
            dtpDateCreated.Value = purchase_order.date_created;
            tbProjectID.Text = purchase_order.project_id;
            tbRemarks.Text = purchase_order.remarks;
        }

        private void tbSearchEmployee_TextChanged(object sender, EventArgs e)
        {
        }
        private void autofillValues()
        {
            suppliers = db.getSupplierList();
            cbSupplierList.Items.Clear();
            cbSupplierList.Items.AddRange(suppliers.Keys.ToArray());

            requesters = db.getRequesterList();
            cbRequester.Items.Clear();
            cbRequester.Items.AddRange(requesters.Keys.ToArray());

            AutoCompleteStringCollection denominations = new AutoCompleteStringCollection();
            denominations.AddRange(db.getDenominations().ToArray());
            tbRemarks.AutoCompleteCustomSource = denominations;



        }

        private void cbSites_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dgvEmployees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to edit purchase order '"+ purchase_order.control_number+"'? ","Editing purchase order"+purchase_order.control_number,MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (supplier.supplier_name == "")
                {
                    errorProvider1.SetError(cbSupplierList,"Please choose a supplier!");

                }
                else if (requester.requester_name == "")
                {
                    errorProvider1.SetError(cbRequester,"Please choose a requester!");
                }
                else{ 
                db.editPurchaseOrder(purchase_order);
                this.Close();
                
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
            new Add_Supplier(ref cbSupplierList,ref suppliers).Show();
        }

        private void btnAddRequester_Click(object sender, EventArgs e)
        {
            new Add_Requester(ref cbRequester,ref requesters).Show();
        }

        private void cbSupplierList_SelectedIndexChanged(object sender, EventArgs e)
        {
             supplier = db.getSupplierByID(suppliers[cbSupplierList.Text]);
            lblSupplierID.Text = supplier.supplier_id;
            lblSupplierName.Text = supplier.supplier_name;
            lblAccountNumber.Text = supplier.account_number;
            lblSupplierAddress.Text = supplier.supplier_address;
            lblContactNumber.Text = supplier.contact_number;
            purchase_order.supplier_id = supplier.supplier_id;
        }

        private void cbRequester_SelectedIndexChanged(object sender, EventArgs e)
        {

             requester = db.getRequesterByID(requesters[cbRequester.Text]);
            lblRequesterName.Text = requester.requester_name;
            lblRequesterContact.Text = requester.requester_contact_number;
            lblRequesterID.Text = requester.requester_id;
            lblPosition.Text = requester.requester_designation;
            lblRequesterDesignation.Text = requester.requester_position;
            purchase_order.requester_id = requester.requester_id;
        }

        private void btnEditSupplier_Click(object sender, EventArgs e)
        {

        }
    }
}
