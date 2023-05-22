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
    public partial class Edit_Requester : Form
    {
        Models.Requester requester = new Models.Requester();
        Controller.Database database = new Controller.Database();
        ComboBox requesterComboBox = new ComboBox();
        Dictionary<String, String> requesters = new Dictionary<String, String>();
        public Edit_Requester(Models.Requester requester)
        {
            InitializeComponent();
            this.requester = requester;
        }


        private void Add_Requester_Load(object sender, EventArgs e)
        {
            tbRequesterName.Text = requester.requester_name;
            tbPosition.Text = requester.requester_position;
            tbDesignation.Text = requester.requester_designation;
            tbContactNumber.Text = requester.requester_contact_number;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to edit requester "+requester.requester_name+"'s record?","Editing " + requester.requester_name + "'s record",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                requester.requester_name = tbRequesterName.Text;
                requester.requester_contact_number = tbContactNumber.Text;
                requester.requester_position = tbPosition.Text;
                requester.requester_designation = tbDesignation.Text;
                database.editRequester(requester);
                this.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete requester " + requester.requester_name + "'s record?", "Deleting " + requester.requester_name + "'s record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                database.deleteRequester(requester);
                this.Close();
            }
        }
    }
}
