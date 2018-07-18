using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Trasher.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public int Zip { get; set; }
    }
}