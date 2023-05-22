using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomnPhil_Construction.Models
{
   public class Equipment
    {         

            public String cr_number { get; set; }
            public String plate_number { get; set; }
            public String mv_file_number  { get; set; }
            public String engine_number  { get; set; }
            public String chassis_number  { get; set; }
            public String denomination  { get; set; }
            public int piston_displacement { get; set; }
            public String no_of_cylinders { get; set; }
            public String fuel  { get; set; }
            public String make { get; set; }
            public String series  { get; set; }
            public String body_type  { get; set; }
            public String year_model  { get; set; }
            public int gross_weight  { get; set; }
            public int net_weight  { get; set; }
            public int shipping_weight  { get; set; }
            public int net_capacity  { get; set; }
            public String complete_owner_name  { get; set; }
            public String complete_owner_address  { get; set; }
            public String status  { get; set; }
            public String or_no  { get; set; }
            public DateTime renewal_date { get; set; }
            public DateTime insurance_renewal  { get; set; }
            public DateTime or_date  { get; set; }
            public String control_number  { get; set; }
            public Double equipment_price  { get; set; }
            public String serial  { get; set; }
            public String site  { get; set; }
            public Double cr_payment  { get; set; }
            public String image  { get; set; }
    }
}
