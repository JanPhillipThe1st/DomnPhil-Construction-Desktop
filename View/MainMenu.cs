using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using DomnPhil_Construction.View.Purchase_Orders;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DomnPhil_Construction.View
{
    public partial class MainMenu : Form
    {
        bool isAdmin = false;
        public MainMenu(bool isAdmin)
        {
            InitializeComponent();
            this.isAdmin = isAdmin;
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            new Employees().Show();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            new Monthly_Attendance().Show();
        }

        private void btnEquipments_Click(object sender, EventArgs e)
        {
            new Equipments.Equipments().Show();
        }

        private void btnCashAdvanceLoan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is still 'under construction'.");
        }

        private void btnPurchaseOrders_Click(object sender, EventArgs e)
        {
            new Purchase_Orders.Purchase_Orders().Show();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            if (isAdmin)
            {
                btnSettings.Visible = true;
            }
            else {
                btnSettings.Visible = false;
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            new AddQuantityController().Show();
        }
    }
}
