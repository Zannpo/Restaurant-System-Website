using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RestaurantSystem.Models;

namespace RestaurantSystem.Pages.Nowy
{
    public class IndexModel : PageModel
    {
        private readonly RestaurantSystem.Models.RamenikDBContext _context;

        public IndexModel(RestaurantSystem.Models.RamenikDBContext context)
        {
            _context = context;
        }

        public IList<SpecialOffer> SpecialOffer { get;set; }

        public async Task OnGetAsync()
        {
            SpecialOffer = await _context.SpecialOffers.ToListAsync();
        }
    }
}
