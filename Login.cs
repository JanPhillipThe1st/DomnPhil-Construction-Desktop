using DomnPhil_Construction.Controller;
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
            if(db.adminLogin(tbUsername.Text, tbPassword.Text)){
                //new Employees().Show();
                //new Monthly_Attendance().Show();
                if (tbUsername.Text == "janphillip")
                {
                    new View.MainMenu(true).Show();

                }
                else { 
                
                    new View.MainMenu(false).Show();
                }
            }
        }
    }
}
