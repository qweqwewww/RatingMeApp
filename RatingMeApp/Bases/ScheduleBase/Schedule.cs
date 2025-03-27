using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatingMeApp.Bases.ScheduleBase
{
    public class Schedule
    {
        public int ScheduleID { get; set; }
        public string? CheckDate { get; set; }
        public string? One { get; set; }
        public string? Two { get; set; }
        public string? Three { get; set; }
        public string? Four { get; set; }
        public string? Five { get; set; }
        public string? Six { get; set; }

    }

    public class Date
    {
        public int DateID { get; set; }
        public string? SetDate { get; set; }
    }

}
