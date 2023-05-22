
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DomnPhil_Construction.Models
{
    public class Employee
    {
        public string control_number { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string name { get; set; }
        public string position { get; set; }
        public string status { get; set; }
        public float shop_rate { get; set; }
        public float operational_rate { get; set; }
        public double absent { get; set; }
        public double breakdown_days_present { get; set; }
        public double operation_days_present { get; set; }
        public double overtime_hours { get; set; }
        public double undertime_hours { get; set; }
        public float overtime_pay { get; set; }
        public float rate { get; set; }
        public float pay { get; set; }
        public string site { get; set; }
        public string designation { get; set; }
        public double cash_advance { get; set; }
        public double loan { get; set; }
        public double sss { get; set; }
        public double pag_ibig { get; set; }
        public double philhealth { get; set; }
        public double month_end_cash_advance { get; set; }
    }
}
