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
    public class DetailsModel : PageModel
    {
        private readonly RestaurantSystem.Models.RamenikDBContext _context;

        public DetailsModel(RestaurantSystem.Models.RamenikDBContext context)
        {
            _context = context;
        }

        public SpecialOffer SpecialOffer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            SpecialOffer = await _context.SpecialOffers.FirstOrDefaultAsync(m => m.IdSpecialOffer == id);

            if (SpecialOffer == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
