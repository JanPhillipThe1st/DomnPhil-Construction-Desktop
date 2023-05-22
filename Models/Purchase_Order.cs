using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomnPhil_Construction.Models
{
    public class Purchase_Order
    {
        public String control_number { get; set; }
        public String supplier_id { get; set; }
        public String charges { get; set; }
        public DateTime date_created { get; set; }
        public String delivered_to { get; set; }
        public Double partial_payment { get; set; }
        public String remarks { get; set; }
        public String requester_id { get; set; }
        public String project_id { get; set; }
        public String location { get; set; }
        public String mode_of_payment { get; set; }
        public String site { get; set; }
    }
}
