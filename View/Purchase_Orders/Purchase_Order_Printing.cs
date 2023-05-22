using DomnPhil_Construction.Controller;
using DomnPhil_Construction.Models;
using Microsoft.Reporting.WinForms;
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
    public partial class Purchase_Order_Printing : Form
    {
        Database database = new Database();
        Purchase_Order purchase_order = new Purchase_Order();
        public Purchase_Order_Printing(Purchase_Order purchase_order)
        {
            InitializeComponent();
            this.purchase_order = purchase_order;
        }
        
        private void Purchase_Order_Printing_Load(object sender, EventArgs e)
        {
            this.purchaseOrderReport.RefreshReport();
            purchaseOrderReport.LocalReport.DataSources.Clear();

            Supplier supplier = database.getSupplierByID(purchase_order.supplier_id);
            Requester requester = database.getRequesterByID(purchase_order.requester_id);
            ReportParameter PO_control_number = new ReportParameter("PO_control_number", purchase_order.control_number);
            this.purchaseOrderReport.LocalReport.SetParameters(new ReportParameter[] { PO_control_number });
            ReportParameter supplier_name = new ReportParameter("supplier_name", supplier.supplier_name);
            this.purchaseOrderReport.LocalReport.SetParameters(new ReportParameter[] { supplier_name });
            ReportParameter supplier_address = new ReportParameter("supplier_address", supplier.supplier_address);
            this.purchaseOrderReport.LocalReport.SetParameters(new ReportParameter[] { supplier_address });
            ReportParameter supplier_account_number = new ReportParameter("supplier_account_number", supplier.account_number);
            this.purchaseOrderReport.LocalReport.SetParameters(new ReportParameter[] { supplier_account_number });
            ReportParameter supplier_contact_number = new ReportParameter("supplier_contact_number", supplier.contact_number);
            this.purchaseOrderReport.LocalReport.SetParameters(new ReportParameter[] { supplier_name });
            ReportParameter date_printed = new ReportParameter("date_printed", DateTime.Now.ToString("MMMM dd, yyyy"));
            this.purchaseOrderReport.LocalReport.SetParameters(new ReportParameter[] { date_printed });
            ReportParameter charges = new ReportParameter("charges", purchase_order.charges);
            this.purchaseOrderReport.LocalReport.SetParameters(new ReportParameter[] { charges });
            ReportParameter delivered_to = new ReportParameter("delivered_to", purchase_order.delivered_to);
            this.purchaseOrderReport.LocalReport.SetParameters(new ReportParameter[] { delivered_to });

            ReportParameter invoice_subtotal = new ReportParameter("invoice_subtotal", String.Format("PHP {0:#,###.##0}",database.getPurchaseTotal(purchase_order.control_number)));
            this.purchaseOrderReport.LocalReport.SetParameters(new ReportParameter[] { invoice_subtotal });

            ReportParameter partial_payment = new ReportParameter("partial_payment", String.Format("PHP {0:#,###.##0}", purchase_order.partial_payment));
            this.purchaseOrderReport.LocalReport.SetParameters(new ReportParameter[] { partial_payment });

            ReportParameter purchase_order_total = new ReportParameter("purchase_order_total", String.Format("PHP {0:#,###.##0}", (database.getPurchaseTotal(purchase_order.control_number)) - (purchase_order.partial_payment)));
            this.purchaseOrderReport.LocalReport.SetParameters(new ReportParameter[] { purchase_order_total });
            //Requester Data
            ReportParameter requester_name = new ReportParameter("requester_name", requester.requester_name);
            this.purchaseOrderReport.LocalReport.SetParameters(new ReportParameter[] { requester_name });
            ReportParameter requester_contact_number = new ReportParameter("requester_contact_number", requester.requester_contact_number);
            this.purchaseOrderReport.LocalReport.SetParameters(new ReportParameter[] { requester_contact_number });
            ReportParameter requester_position = new ReportParameter("requester_position", requester.requester_position);
            this.purchaseOrderReport.LocalReport.SetParameters(new ReportParameter[] { requester_position });
            ReportParameter requester_designation = new ReportParameter("requester_designation", requester.requester_designation);
            this.purchaseOrderReport.LocalReport.SetParameters(new ReportParameter[] { requester_designation });
            //Purchase Order Data
            ReportParameter purchase_order_project_id = new ReportParameter("purchase_order_project_id", purchase_order.project_id);
            this.purchaseOrderReport.LocalReport.SetParameters(new ReportParameter[] { purchase_order_project_id });
            ReportParameter location = new ReportParameter("purchase_order_location", purchase_order.charges);
            this.purchaseOrderReport.LocalReport.SetParameters(new ReportParameter[] { location });
            ReportParameter mode_of_payment = new ReportParameter("mode_of_payment", purchase_order.mode_of_payment);
            this.purchaseOrderReport.LocalReport.SetParameters(new ReportParameter[] { mode_of_payment });
            purchaseOrderReport.LocalReport.DataSources.Add(new ReportDataSource("PO_item", database.fillPurchaseOrderItems(purchase_order.control_number)));
            this.purchaseOrderReport.RefreshReport();
        }

        private void purchaseOrderReport_Load(object sender, EventArgs e)
        {

        }
    }
}
