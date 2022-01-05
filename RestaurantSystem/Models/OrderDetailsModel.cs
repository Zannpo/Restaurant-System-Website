using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantSystem.Models
{
    public class OrderDetailsModel
    {
        public int idOrder { get; set; }
        public int idSpecialOffer { get; set; }
        public DateTime orderDate { get; set; }
        public DateTime DateTime { get; set; }
        public string orderStatus { get; set; }
        public string paymentOption{ get; set; }
        public string comment { get; set; }
        public decimal totalCost { get; set; }
        public decimal deliveryCost { get; set; }
    }
}
