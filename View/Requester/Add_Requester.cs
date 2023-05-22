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
    public partial class Add_Requester : Form
    {
        Models.Requester requester = new Models.Requester();
        Controller.Database database = new Controller.Database();
        ComboBox requesterComboBox = new ComboBox();
        Dictionary<String, String> requesters = new Dictionary<String, String>();
        public Add_Requester(ref ComboBox requesterComboBox, ref Dictionary<String, String> requesters)
        {
            InitializeComponent();
            this.requesterComboBox = requesterComboBox;
            this.requesters = requesters;
        }


        private void Add_Requester_Load(object sender, EventArgs e)
        {
            AutoCompleteStringCollection source = new AutoCompleteStringCollection();
            source.AddRange(database.getEmployeeNames().ToArray());
            tbRequesterName.AutoCompleteCustomSource = source;

            AutoCompleteStringCollection positionSource = new AutoCompleteStringCollection();
            positionSource.AddRange(database.getPositionList().ToArray());
            tbPosition.AutoCompleteCustomSource = positionSource;
        }

        private void btnAddRequester_Click(object sender, EventArgs e)
        {

            requester.requester_name = tbRequesterName.Text;
            requester.requester_position = tbPosition.Text;
            requester.requester_contact_number = tbContactNumber.Text;
            requester.requester_designation = tbDesignation.Text;
            database.addRequesterData(requester);
            requesters = database.getRequesterList();
            requesterComboBox.Items.Clear();
            requesterComboBox.Items.AddRange(requesters.Keys.ToArray());
        }
    }
}
