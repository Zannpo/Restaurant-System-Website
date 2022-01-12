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
    public class DeleteModel : PageModel
    {
        private readonly RestaurantSystem.Models.RamenikDBContext _context;

        public DeleteModel(RestaurantSystem.Models.RamenikDBContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            SpecialOffer = await _context.SpecialOffers.FindAsync(id);

            if (SpecialOffer != null)
            {
                _context.SpecialOffers.Remove(SpecialOffer);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
