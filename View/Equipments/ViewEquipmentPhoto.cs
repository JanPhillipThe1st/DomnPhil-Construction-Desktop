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
    public partial class ViewEquipmentPhoto : Form
    {
        Models.Equipment equipment = new Models.Equipment();
        public ViewEquipmentPhoto(Models.Equipment equipment)
        {
            InitializeComponent();
            this.equipment = equipment;
        }

        private void ViewEquipmentPhoto_Load(object sender, EventArgs e)
        {
            pbEquipmentPhoto.BackgroundImage = Image.FromFile(Application.StartupPath +"/" +equipment.image);
        }
    }
}
