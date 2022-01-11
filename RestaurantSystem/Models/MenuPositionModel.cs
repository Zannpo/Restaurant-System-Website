using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantSystem.Models
{
    public class MenuPositionModel
    {
        public int idCourse { get; set; }
        public string courseType { get; set; }
        public string courseName { get; set; }
        public string ingredients { get; set; }
        public decimal courseCost { get; set; }
        public string courseImage { get; set; }
    }
}
