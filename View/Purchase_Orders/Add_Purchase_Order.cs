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
    public partial class Add_Purchase_Order : Form
    {
        Database db = new Database();
        Equipment equipment = new Equipment();
        Models.Purchase_Order purchase_order = new Purchase_Order();
        InputUtilities inputUtilities = new InputUtilities();
        DataGridView dgv = new DataGridView();
        Models.Supplier supplier = new Supplier();
        Requester requester = new Requester();
        Dictionary<String, String> suppliers = new Dictionary<String, String>();
        Dictionary<String, String> requesters = new Dictionary<String, String>();
        public Add_Purchase_Order(DataGridView dgv)
        {
            InitializeComponent();
            this.dgv = dgv;
        }

        private void btnTogglePasswordVisibilty_Click(object sender, EventArgs e)
        {
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            db.fillPurchaseOrders(ref dgvPurchaseOrders);
            autofillValues();
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
            if (inputUtilities.completelyFilled(gbEmployeeDetails, errorProvider1))
            {
                if (MessageBox.Show("Are you sure you want to save this record?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    purchase_order.control_number = tbControlNumber.Text;
                    purchase_order.charges = tbCharges.Text;
                    purchase_order.remarks = tbRemarks.Text;
                    purchase_order.delivered_to = tbDeliveredTo.Text;
                    purchase_order.mode_of_payment = cbModeOfPayment.Text;
                    purchase_order.site = tbSites.Text;
                    purchase_order.project_id = tbProjectID.Text;
                    try
                    {
                        purchase_order.partial_payment = Double.Parse(tbPartialPayment.Text);
                        db.addPurchaseOrder(purchase_order);
                        db.fillPurchaseOrders(ref dgvPurchaseOrders);
                    }
                    catch (FormatException ex)
                    {
                        tbPartialPayment.Text = "0.00";
                        errorProvider1.SetError(tbPartialPayment, "Please provide a valid amount!");
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
            Add_Supplier add_Supplier = new Add_Supplier(ref cbSupplierList, ref suppliers);
            add_Supplier.Show();
            add_Supplier.FormClosed += Add_Supplier_FormClosed;
        }

        private void Add_Supplier_FormClosed(object sender, FormClosedEventArgs e)
        {
            autofillValues();
        }

        private void btnAddRequester_Click(object sender, EventArgs e)
        {
            Add_Requester add_Requester = new Add_Requester(ref cbRequester, ref requesters);
            add_Requester.Show();
            add_Requester.FormClosed += Add_Requester_FormClosed;
        }

        private void Add_Requester_FormClosed(object sender, FormClosedEventArgs e)
        {
            autofillValues();
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
        private void checkSupplierInformation()
        {
            if (supplier.supplier_id != "")
            {
                btnEditSupplier.Visible = true;
            }
            else
            {
                btnEditSupplier.Visible = false;
            }
        }


        private void checkRequesterInformation()
        {
            if (requester.requester_id!= "")
            {
                btnEditRequester.Visible = true;
            }
            else
            {
                btnEditRequester.Visible = true;
            }
        }

        private void lblContactNumber_TextChanged(object sender, EventArgs e)
        {
            checkSupplierInformation();
        }

        private void lblRequesterName_TextChanged(object sender, EventArgs e)
        {
            checkRequesterInformation();
        }

        private void btnEditRequester_Click(object sender, EventArgs e)
        {
          Edit_Requester edit_requester  = new Edit_Requester(requester);
            edit_requester.Show();
            edit_requester.FormClosed += Edit_requester_FormClosed;
        }

        private void Edit_requester_FormClosed(object sender, FormClosedEventArgs e)
        {
            autofillValues();
        }

        private void btnEditSupplier_Click(object sender, EventArgs e)
        {
            Edit_Supplier edit_supplier= new Edit_Supplier(supplier);
            edit_supplier.Show();
            edit_supplier.FormClosed += Edit_supplier_FormClosed;
        }

        private void Edit_supplier_FormClosed(object sender, FormClosedEventArgs e)
        {
            autofillValues();
        }
    }
}
