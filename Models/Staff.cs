using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace ScheduleUs.Models
{
    public class Staff
    {
        public int StaffId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        //public string? MiddleName { get; set; }
        //public string? NickName { get; set; }
        public string HomeUnit { get; set; }
        public string Shift { get; set; }
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }


    }
}