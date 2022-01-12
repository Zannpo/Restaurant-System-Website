using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RestaurantSystem.Models;

namespace RestaurantSystem.Pages.Nowy
{
    public class CreateModel : PageModel
    {
        private readonly RestaurantSystem.Models.RamenikDBContext _context;

        public CreateModel(RestaurantSystem.Models.RamenikDBContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public SpecialOffer SpecialOffer { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.SpecialOffers.Add(SpecialOffer);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
