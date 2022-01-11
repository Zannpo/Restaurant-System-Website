using System;
using System.Collections.Generic;

#nullable disable

namespace RestaurantSystem.Models
{
    public partial class MenuPosition
    {
        public int IdCourse { get; set; }
        public string CourseType { get; set; }
        public string CourseName { get; set; }
        public string Ingredients { get; set; }
        public decimal? CourseCost { get; set; }
        public string CourseImage { get; set; }
    }
}
