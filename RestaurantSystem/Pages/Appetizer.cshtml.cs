using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RestaurantSystem.Models;

namespace RestaurantSystem.Pages
{
    public class AppetizerModel : PageModel
    {
        [BindProperty]
        public MenuPosition MenuPosition { get; set; }

        public List<MenuPosition> AllPositions = new List<MenuPosition>();

        private readonly RamenikDBContext _ramenikDBContext;
        public AppetizerModel(RamenikDBContext ramenikDBContext)
        {
            _ramenikDBContext = ramenikDBContext;
        }

        public void OnGet()
        {

            using (var context = new RamenikDBContext())
            {
                var dishes = from dish in context.MenuPositions
                             where dish.CourseType == "Przystawka"
                             select dish;

                AllPositions = dishes.ToList<MenuPosition>();
            }
        }
    }
}
