using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DomnPhil_Construction.View.Suppliers
{
    public partial class Edit_Supplier : Form
    {
        Models.Supplier supplier = new Models.Supplier();
        Controller.Database database = new Controller.Database();
        ComboBox supplierComboBox = new ComboBox();
        Dictionary<String, String> suppliers = new Dictionary<String, String>();
        public Edit_Supplier(Models.Supplier supplier)
        {
            InitializeComponent();
            this.supplier = supplier;
        }

        private void Edit_Supplier_Load(object sender, EventArgs e)
        {
            tbSupplierName.Text = supplier.supplier_name;
            tbSupplierAddress.Text = supplier.supplier_address;
            tbAccountNumber.Text = supplier.account_number;
            tbContactNumber.Text = supplier.contact_number;
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to edit supplier " + supplier.supplier_name + "'s record?", "Editing " + supplier.supplier_name + "'s record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                supplier.supplier_name = tbSupplierName.Text;
                supplier.supplier_address = tbSupplierAddress.Text;
                supplier.contact_number = tbContactNumber.Text;
                supplier.account_number = tbAccountNumber.Text;
                database.editSupplier(supplier);
                this.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete supplier " + supplier.supplier_name + "'s record?", "Deleting " + supplier.supplier_name+ "'s record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                database.deleteSupplier(supplier);
                this.Close();
            }
        }
    }
}
