using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DomnPhil_Construction.Controller;
using Microsoft.Reporting.WinForms;

namespace DomnPhil_Construction.View.Equipments
{
    public partial class EquipmentListPrinting : Form
    {
        Database database = new Database();
        public EquipmentListPrinting()
        {
            InitializeComponent();
        }

        private void EquipmentListPrinting_Load(object sender, EventArgs e)
        {
            this.equipmentReport.RefreshReport();
            equipmentReport.LocalReport.DataSources.Clear();

            ReportParameter date_printed = new ReportParameter("date_printed", DateTime.Now.ToString("MMMM dd, yyyy"));
            equipmentReport.LocalReport.SetParameters(date_printed);
            equipmentReport.LocalReport.DataSources.Add(new ReportDataSource("Equipment", database.getEquipmentReport()));

            this.equipmentReport.RefreshReport();
        }

        private void equipmentReport_Load(object sender, EventArgs e)
        {

        }
    }
}
