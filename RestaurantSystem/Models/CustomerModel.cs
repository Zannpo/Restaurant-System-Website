using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantSystem.Models
{
    public class CustomerModel
    {
        public int idCustomer { get; set; }
        public int phoneNumber { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string comment { get; set; }
        public DateTime deliveryTime { get; set; }
    }
}
