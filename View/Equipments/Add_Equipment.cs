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

namespace DomnPhil_Construction
{
    public partial class Add_Equipment : Form
    {
        Database db = new Database();
        Equipment equipment = new Equipment();
        InputUtilities inputUtilities = new InputUtilities();
        DataGridView dgv = new DataGridView();
        public Add_Equipment( DataGridView dgv)
        {
            InitializeComponent();
            this.dgv = dgv;
        }

        private void btnTogglePasswordVisibilty_Click(object sender, EventArgs e)
        {
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            lblEquipment.Text = "Add Equipment";
            autofillValues();

        }

        private void tbSearchEmployee_TextChanged(object sender, EventArgs e)
        {
        }
        private void autofillValues() {

            AutoCompleteStringCollection denominations = new AutoCompleteStringCollection();
            denominations.AddRange(db.getDenominations().ToArray());
            tbDenomination.AutoCompleteCustomSource = denominations;
            
            AutoCompleteStringCollection fuels = new AutoCompleteStringCollection();
            fuels.AddRange(db.getFuels().ToArray());
            tbFuel.AutoCompleteCustomSource = fuels;
            
            AutoCompleteStringCollection makes = new AutoCompleteStringCollection();
            makes.AddRange(db.getMakes().ToArray());
            tbMake.AutoCompleteCustomSource = makes;
            
            AutoCompleteStringCollection series = new AutoCompleteStringCollection();
            series.AddRange(db.getSeries().ToArray());
            tbSeries.AutoCompleteCustomSource = series;
            
            AutoCompleteStringCollection bodyTypes = new AutoCompleteStringCollection();
            bodyTypes.AddRange(db.getBodyTypes().ToArray());
            tbBodyType.AutoCompleteCustomSource = bodyTypes;
            
            AutoCompleteStringCollection yearModels = new AutoCompleteStringCollection();
            yearModels.AddRange(db.getYearModels().ToArray());
            tbYearModel.AutoCompleteCustomSource = yearModels;
            
            AutoCompleteStringCollection CONs = new AutoCompleteStringCollection();
            CONs.AddRange(db.getCON().ToArray());
            tbCompleteOwnerName.AutoCompleteCustomSource = CONs;
            
            AutoCompleteStringCollection COAs = new AutoCompleteStringCollection();
            COAs.AddRange(db.getCOA().ToArray());
            tbCompleteOwnersAddress.AutoCompleteCustomSource = COAs;
            
            AutoCompleteStringCollection statuses = new AutoCompleteStringCollection();
            statuses.AddRange(db.getStatus().ToArray());
            tbStatus.AutoCompleteCustomSource = statuses;
            
            AutoCompleteStringCollection sites = new AutoCompleteStringCollection();
            sites.AddRange(db.getSites().ToArray());
            tbSite.AutoCompleteCustomSource = sites;


        }

        private void cbSites_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dgvEmployees_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            equipment.body_type = tbBodyType.Text;
            equipment.control_number = tbControlNumber.Text;
            equipment.cr_number = tbCertRegNo.Text;
            equipment.plate_number = tbPlateNo.Text;
            equipment.mv_file_number = tbMVFIleNo.Text;
            equipment.engine_number = tbEngineNo.Text;
            equipment.chassis_number = tbChassisNo.Text;
            equipment.denomination = tbDenomination.Text;
            try
            {
                Convert.ToInt32(tbPistonDisplacement.Text);
                Convert.ToInt32(tbGrossWeight.Text);
                Convert.ToInt32(tbNetWeight.Text);
                Convert.ToInt32(tbShippingWeight.Text);
                Convert.ToInt32(tbNetCapacity.Text);
                Convert.ToDouble(tbEquipmentPrice.Text);
                Convert.ToDouble(tbCertificateOfRegistrationPrice.Text);

            }
            catch (Exception)
            {
                tbPistonDisplacement.Text = "0";
                tbGrossWeight.Text = "0";
                tbNetWeight.Text = "0";
                tbShippingWeight.Text = "0";
                tbNetCapacity.Text = "0";
                tbEquipmentPrice.Text = "0";
                tbCertificateOfRegistrationPrice.Text = "0";
            }
            equipment.piston_displacement = Convert.ToInt32(tbPistonDisplacement.Text);
            equipment.no_of_cylinders = tbNumberOfCylinders.Text;
            equipment.fuel = tbFuel.Text;
            equipment.make = tbMake.Text;
            equipment.series = tbSeries.Text;
            equipment.body_type = tbBodyType.Text;
            equipment.year_model = tbYearModel.Text;
            equipment.gross_weight = Convert.ToInt32(tbGrossWeight.Text);
            equipment.net_weight = Convert.ToInt32(tbNetWeight.Text);
            equipment.shipping_weight = Convert.ToInt32(tbShippingWeight.Text);
            equipment.net_capacity = Convert.ToInt32(tbNetCapacity.Text);
            equipment.complete_owner_name = tbCompleteOwnerName.Text;
            equipment.complete_owner_address = tbCompleteOwnersAddress.Text;
            equipment.status = tbStatus.Text;
            equipment.or_no = tbOfficialCertificateNumber.Text;
            equipment.renewal_date = dtpRenewalDate.Value;
            equipment.insurance_renewal = dtpInsuranceRenewal.Value;
            equipment.or_date = dtpOfficialReceiptDate.Value;
            equipment.equipment_price = Convert.ToDouble(tbEquipmentPrice.Text);
            equipment.serial = tbSerial.Text;
            equipment.site = tbSite.Text;
            equipment.cr_payment = Convert.ToDouble(tbCertificateOfRegistrationPrice.Text);
            if (MessageBox.Show("Are you sure you want to save this record?","Saving record",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.addEquipment(equipment);
                db.fillEquipmentsTable(ref dgv);
            }

        }

        private void tbNonOperationalDays_TextChanged(object sender, EventArgs e)
        {
            try
            {
            tbNetWeight.Text = (Convert.ToInt32(tbGrossWeight.Text)/2).ToString();
            tbNetCapacity.Text = (Convert.ToInt32(tbGrossWeight.Text) / 2).ToString();
            tbShippingWeight.Text = (Convert.ToInt32(tbGrossWeight.Text) / 2).ToString();

            }
            catch (Exception ex)
            {
                tbGrossWeight.Text = "0";
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
            if (inputUtilities.isDouble(tbEquipmentPrice.Text))
            {

            }
            else
            {
                tbEquipmentPrice.Clear();
            }
        }

        private void tbCertificateOfRegistrationPrice_TextChanged(object sender, EventArgs e)
        {
            if (inputUtilities.isDouble(tbCertificateOfRegistrationPrice.Text))
            {

            }
            else
            {
                tbCertificateOfRegistrationPrice.Clear();
            }
        }
    }
}
