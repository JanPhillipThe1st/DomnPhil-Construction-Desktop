using DomnPhil_Construction.Controller;
using DomnPhil_Construction.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DomnPhil_Construction
{
    public partial class Edit_Equipment : Form
    {
        Database db = new Database();
        Equipment equipment = new Equipment();
        InputUtilities inputUtilities = new InputUtilities();
        DataGridView dgv = new DataGridView();
        public Edit_Equipment(Equipment equipment,  DataGridView dgv)
        {
            InitializeComponent();
            this.equipment = equipment;
            this.dgv = dgv;
        }

        private void btnTogglePasswordVisibilty_Click(object sender, EventArgs e)
        {
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            lblEquipment.Text = "Equipment: "+ equipment.control_number +", "+equipment.plate_number;

            tbBodyType.Text = equipment.body_type;
            tbControlNumber.Text = equipment.control_number  ;
            tbCertRegNo.Text = equipment.cr_number;
            tbPlateNo.Text = equipment.plate_number;
            tbMVFIleNo.Text = equipment.mv_file_number;
            tbEngineNo.Text = equipment.engine_number;
            tbChassisNo.Text = equipment.chassis_number;
            tbDenomination.Text = equipment.denomination;
            tbPistonDisplacement.Text = equipment.piston_displacement.ToString() ;
            tbNumberOfCylinders.Text = equipment.no_of_cylinders;
            tbFuel.Text = equipment.fuel;
            tbMake.Text = equipment.make;
            tbSeries.Text = equipment.series;
            tbBodyType.Text = equipment.body_type;
            tbYearModel.Text = equipment.year_model;
            tbGrossWeight.Text= equipment.gross_weight.ToString();
            tbNetWeight.Text = equipment.net_weight.ToString();
            tbShippingWeight.Text = equipment.shipping_weight.ToString();
            tbNetCapacity.Text = equipment.net_capacity.ToString() ;
            tbCompleteOwnerName.Text = equipment.complete_owner_name;
            tbCompleteOwnersAddress.Text = equipment.complete_owner_address;
            tbStatus.Text = equipment.status;
            tbOfficialCertificateNumber.Text = equipment.or_no;
            dtpRenewalDate.Value = equipment.renewal_date;
            dtpInsuranceRenewal.Value = equipment.insurance_renewal;
            dtpOfficialReceiptDate.Value = equipment.or_date;
            tbEquipmentPrice.Text = equipment.equipment_price.ToString();
            tbSerial.Text = equipment.serial;
            tbSite.Text = equipment.site;
            tbCertificateOfRegistrationPrice.Text = equipment.cr_payment.ToString();
            loadImage();

        }

        private void tbSearchEmployee_TextChanged(object sender, EventArgs e)
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
            equipment.body_type = tbBodyType.Text;
            equipment.control_number = tbControlNumber.Text;
            equipment.cr_number = tbCertRegNo.Text;
            equipment.plate_number = tbPlateNo.Text;
            equipment.mv_file_number = tbMVFIleNo.Text;
            equipment.engine_number = tbEngineNo.Text;
            equipment.chassis_number = tbChassisNo.Text;
            equipment.denomination = tbDenomination.Text;
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
            loadImage();
            if (MessageBox.Show("Are you sure you want to save this record?","Saving record",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.editEquipment(equipment);
                db.fillEquipmentsTable(ref dgv);
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

        private void pbEquipmentImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
            equipment.image = openFileDialog.SafeFileName;
                // Get the path to the selected image file
                string filePath = openFileDialog.FileName;

                // Get the path to the folder where you want to move the file
                string folderPath = Application.StartupPath;

                // Use the System.IO namespace to move the file
                File.Move(filePath, System.IO.Path.Combine(folderPath, System.IO.Path.GetFileName(filePath)));
                db.setEquipmentImage(equipment);
                loadImage();
            }
        }
        private void loadImage() {
            if (equipment.image != "")
            {
            pbEquipmentImage.BackgroundImage = Image.FromFile(Application.StartupPath + "/"+equipment.image);
            }
            else{

            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            new View.Equipments.ViewEquipmentPhoto(equipment).Show();
        }

        private void btnPrintEquipmentReport_Click(object sender, EventArgs e)
        {
            new View.Equipments.EquipmentDetailsReport(equipment).Show();
        }
    }
}
