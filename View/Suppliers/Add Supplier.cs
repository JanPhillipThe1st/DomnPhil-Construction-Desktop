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
    public partial class Add_Supplier : Form
    {
        Models.Supplier supplier = new Models.Supplier();
        Controller.Database database = new Controller.Database();
        ComboBox supplierComboBox = new ComboBox();
        Dictionary<String, String> suppliers = new Dictionary<String, String>();
        public Add_Supplier(ref ComboBox supplierComboBox,ref Dictionary<String, String> suppliers)
        {
            InitializeComponent();
            this.supplierComboBox = supplierComboBox;
            this.suppliers = suppliers;
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            supplier.supplier_name = tbSupplierName.Text;
            supplier.supplier_address = tbSupplierAddress.Text;
            supplier.contact_number = tbContactNumber.Text;
            supplier.account_number = tbAccountNumber.Text;
            database.addSupplierData(supplier);
            suppliers = database.getSupplierList();
            supplierComboBox.Items.Clear();
            supplierComboBox.Items.AddRange(suppliers.Keys.ToArray()) ;
        }
    }
}
