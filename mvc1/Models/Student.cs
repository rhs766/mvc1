using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc1.Models
{
    public class Student
    {
        public int ID { get; set; }
        public Guid UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Period { get; set; }

    }
}