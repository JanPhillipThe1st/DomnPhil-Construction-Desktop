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

namespace DomnPhil_Construction.View.Equipments
{
    public partial class EquipmentDetailsReport : Form
    {
        Controller.Database database = new Controller.Database();
        Models.Equipment equipment = new Models.Equipment();
        public EquipmentDetailsReport(Models.Equipment equipment)
        {
            InitializeComponent();
            this.equipment = equipment;
        }

        private void EquipmentDetailsReport_Load(object sender, EventArgs e)
        {
            this.equipmentDetailsReportViewer.RefreshReport();
            equipmentDetailsReportViewer.LocalReport.DataSources.Clear();
            equipmentDetailsReportViewer.LocalReport.EnableExternalImages = true;
            

            equipmentDetailsReportViewer.LocalReport.SetParameters(new ReportParameter("control_number", equipment.control_number));
            equipmentDetailsReportViewer.LocalReport.SetParameters(new ReportParameter("plate_number", equipment.plate_number));
            equipmentDetailsReportViewer.LocalReport.SetParameters(new ReportParameter("cr_number", equipment.cr_number));
            equipmentDetailsReportViewer.LocalReport.SetParameters(new ReportParameter("mv_file_number", equipment.mv_file_number));
            equipmentDetailsReportViewer.LocalReport.SetParameters(new ReportParameter("engine_number", equipment.engine_number));
            equipmentDetailsReportViewer.LocalReport.SetParameters(new ReportParameter("chassis_number", equipment.chassis_number));
            equipmentDetailsReportViewer.LocalReport.SetParameters(new ReportParameter("chassis_number", equipment.chassis_number));
            equipmentDetailsReportViewer.LocalReport.SetParameters(new ReportParameter("no_of_cylinders", equipment.no_of_cylinders));
            equipmentDetailsReportViewer.LocalReport.SetParameters(new ReportParameter("fuel", equipment.fuel));
            equipmentDetailsReportViewer.LocalReport.SetParameters(new ReportParameter("make", equipment.make));
            equipmentDetailsReportViewer.LocalReport.SetParameters(new ReportParameter("series", equipment.series));
            equipmentDetailsReportViewer.LocalReport.SetParameters(new ReportParameter("body_type", equipment.body_type));
            equipmentDetailsReportViewer.LocalReport.SetParameters(new ReportParameter("year_model", equipment.year_model));
            equipmentDetailsReportViewer.LocalReport.SetParameters(new ReportParameter("denomination", equipment.denomination));
            equipmentDetailsReportViewer.LocalReport.SetParameters(new ReportParameter("gross_weight", equipment.gross_weight.ToString()));
            equipmentDetailsReportViewer.LocalReport.SetParameters(new ReportParameter("net_weight", equipment.net_weight.ToString()));
            equipmentDetailsReportViewer.LocalReport.SetParameters(new ReportParameter("shipping_weight", equipment.shipping_weight.ToString()));
            equipmentDetailsReportViewer.LocalReport.SetParameters(new ReportParameter("net_capacity", equipment.net_capacity.ToString()));
            equipmentDetailsReportViewer.LocalReport.SetParameters(new ReportParameter("complete_owner_name", equipment.complete_owner_name));
            equipmentDetailsReportViewer.LocalReport.SetParameters(new ReportParameter("piston_displacement", equipment.piston_displacement.ToString()));
            equipmentDetailsReportViewer.LocalReport.SetParameters(new ReportParameter("complete_owner_address", equipment.complete_owner_address));
            equipmentDetailsReportViewer.LocalReport.SetParameters(new ReportParameter("status", equipment.status));
            equipmentDetailsReportViewer.LocalReport.SetParameters(new ReportParameter("or_no", equipment.or_no));
            equipmentDetailsReportViewer.LocalReport.SetParameters(new ReportParameter("or_date", equipment.or_date.ToString("MMMM dd, yyyyy")));
            equipmentDetailsReportViewer.LocalReport.SetParameters(new ReportParameter("equipment_price", equipment.equipment_price.ToString()));
            equipmentDetailsReportViewer.LocalReport.SetParameters(new ReportParameter("serial", equipment.serial));
            equipmentDetailsReportViewer.LocalReport.SetParameters(new ReportParameter("site", equipment.site));
            equipmentDetailsReportViewer.LocalReport.SetParameters(new ReportParameter("cr_payment", equipment.cr_payment.ToString()));
            equipmentDetailsReportViewer.LocalReport.SetParameters(new ReportParameter("date_printed", DateTime.Now.ToString("MMMM dd, yyyy")));
            equipmentDetailsReportViewer.LocalReport.SetParameters(new ReportParameter("image", new Uri(Application.StartupPath +"/"+ equipment.image).AbsoluteUri));

            this.equipmentDetailsReportViewer.RefreshReport();
        }
    }
}
