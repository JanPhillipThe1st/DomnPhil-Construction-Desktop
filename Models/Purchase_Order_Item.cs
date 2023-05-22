using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomnPhil_Construction.Models
{
    public class Purchase_Order_Item
    {
        public String item_number { get; set; }
        public String purchase_order { get; set; }
        public int quantity { get; set; }
        public String unit { get; set; }
        public String description { get; set; }
        public Double unit_cost { get; set; }
        public Double discount { get; set; }
        public Double amount { get; set; }
    }
}
