using System;
using System.Collections.Generic;

#nullable disable

namespace RestaurantSystem.Models
{
    public partial class Customer
    {
        public int IdCustomer { get; set; }
        public int? IdOrder { get; set; }
        public string PhoneNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Comment { get; set; }
    }
}
