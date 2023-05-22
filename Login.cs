using DomnPhil_Construction.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DomnPhil_Construction
{
    public partial class Login : Form
    {
        bool showPassword = false;
        Database db = new Database();
        public Login()
        {
            InitializeComponent();
        }

        private void btnTogglePasswordVisibilty_Click(object sender, EventArgs e)
        {
            if (showPassword)
            {
                tbPassword.PasswordChar = Char.MinValue;
                btnTogglePasswordVisibilty.Text = "Hide";
                showPassword = false;
            }
            else
            {
                tbPassword.PasswordChar = '•';
                btnTogglePasswordVisibilty.Text = "Show";
                showPassword = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var source = tbPassword.Text;
            using (var md5Hash = MD5.Create())
            {
                // Byte array representation of source string
                var sourceBytes = Encoding.UTF8.GetBytes(source);

                // Generate hash value(Byte Array) for input data
                var hashBytes = md5Hash.ComputeHash(sourceBytes);

                // Convert hash byte array to string
                var hash = BitConverter.ToString(hashBytes).Replace("-", string.Empty);
                if (db.adminLogin(tbUsername.Text, hash))
                {
                    //new Employees().Show();
                    //new Monthly_Attendance().Show();
                    if (tbUsername.Text == "janphillip")
                    {
                        new View.MainMenu(true).Show();

                    }
                    else
                    {

                        new View.MainMenu(false).Show();
                    }
                }
            }
          
        }
    }
}
