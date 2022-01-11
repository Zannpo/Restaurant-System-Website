using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RestaurantSystem.Models;

namespace RestaurantSystem.Pages
{
    public class RamenModel : PageModel
    {
        [BindProperty]
        public MenuPosition MenuPosition { get; set; }

        public List<MenuPosition> AllPositions = new List<MenuPosition>();

        private readonly RamenikDBContext _ramenikDBContext;
        public RamenModel(RamenikDBContext ramenikDBContext)
        {
            _ramenikDBContext = ramenikDBContext;
        }

        public void OnGet()
        {            

            using (var context = new RamenikDBContext())
            {
                var dishes = from dish in context.MenuPositions
                            where dish.CourseType == "Ramen"
                            select dish;

                AllPositions = dishes.ToList<MenuPosition>();
            }
        }           

    }
}
