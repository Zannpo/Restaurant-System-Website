using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RestaurantSystem.Models;

namespace RestaurantSystem.Pages.Nowy
{
    public class EditModel : PageModel
    {
        private readonly RestaurantSystem.Models.RamenikDBContext _context;

        public EditModel(RestaurantSystem.Models.RamenikDBContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(SpecialOffer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SpecialOfferExists(SpecialOffer.IdSpecialOffer))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool SpecialOfferExists(int id)
        {
            return _context.SpecialOffers.Any(e => e.IdSpecialOffer == id);
        }
    }
}
