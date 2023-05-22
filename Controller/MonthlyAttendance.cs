using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomnPhil_Construction.Controller
{
    class MonthlyAttendance
    {
        public String id = "";
        public String month = "";
        public DateTime dateFrom = new DateTime();
        public DateTime dateTo = new DateTime();
        public int year = 0;
        public int  working_days = 0;
        public String employee = "";
        public int days_present = 0;
        public int days_absent = 0;
        public int days_breakdown = 0;
        public int overtime_hours = 0;
    }
}
