using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RestaurantSystem.Models;

namespace RestaurantSystem.Pages
{
    public class MenuModel : PageModel
    {

        [BindProperty]
        public MenuPosition MenuPosition { get; set; }

        public List<MenuPosition> AllPositions = new List<MenuPosition>();

        private readonly RamenikDBContext _ramenikDBContext;
        public MenuModel(RamenikDBContext ramenikDBContext)
        {
            _ramenikDBContext = ramenikDBContext;
        }

        public async Task OnGetAsync()
        {
            AllPositions = await _ramenikDBContext.MenuPositions.OrderBy(position => position.IdCourse).ToListAsync();
        }

    }
}
