using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantSystem.Models
{
    public class OrderPosition
    {
        public int IdOrder { get; set; }
        public string courseName { get; set; }
        public int courseQuantity { get; set; }
        public int idOrderPosition { get; set; }
        public double courseCost { get; set; }

    }
}
