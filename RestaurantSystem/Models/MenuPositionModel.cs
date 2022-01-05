using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantSystem.Models
{
    public class MenuPositionModel
    {
        public int idCourse { get; set; }
        public int idCourseType { get; set; }
        public string courseName { get; set; }
        public string ingredients { get; set; }
        public decimal courseCost { get; set; }
    }
}
