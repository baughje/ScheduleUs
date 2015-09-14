using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScheduleUs.Models
{
    public class Unit
    {
        public int UnitId { get; set; }
        public string UnitName { get; set; }
        public int MinimumStaff { get; set; }
    }
}