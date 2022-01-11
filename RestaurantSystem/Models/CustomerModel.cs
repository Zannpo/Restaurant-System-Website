using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantSystem.Models
{
    public class CustomerModel
    {
        public int idCustomer { get; set; }
        [ForeignKey("OrderDetails")]
        public int idOrder { get; set; }
        public int phoneNumber { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string comment { get; set; }
    }
}
