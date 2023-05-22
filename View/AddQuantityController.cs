using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Security.Cryptography;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DomnPhil_Construction.Controller;

namespace DomnPhil_Construction.View
{
    public partial class AddQuantityController : Form
    {
        Models.QuantityController quantityController = new Models.QuantityController();
        new Database database = new Database();
        public AddQuantityController()
        {
            InitializeComponent();
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (tbPassword.Text != "")
            {
                if (tbPassword.Text != tbConfirmPassword.Text)
                {
                    tbPassword.BackColor = Color.Red;
                }
                else { 
                    tbPassword.BackColor = Color.White;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text != tbConfirmPassword.Text)
            {
                MessageBox.Show("Cannot Proceed. Passwords do not match.");
            }
            else
            {
                var source = tbConfirmPassword.Text;

                // Creates an instance of the default implementation of the MD5 hash algorithm.
                using (var md5Hash = MD5.Create())
                {
                    // Byte array representation of source string
                    var sourceBytes = Encoding.UTF8.GetBytes(source);

                    // Generate hash value(Byte Array) for input data
                    var hashBytes = md5Hash.ComputeHash(sourceBytes);

                    // Convert hash byte array to string
                    var hash = BitConverter.ToString(hashBytes).Replace("-", string.Empty);
                    quantityController.password = hash;
                    quantityController.name = tbQCName.Text;
                    quantityController.username = tbUsername.Text;
                    database.addQuantityController(quantityController);
                }
            }
        }
    }
}
