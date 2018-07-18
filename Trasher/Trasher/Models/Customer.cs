using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Trasher.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public string Address { get; set; }
        public int Zip { get; set; }
        public string PickupDay { get; set; }
        public bool IsPickedUp { get; set; }
        public int AmountDue { get; set; }
    }
}