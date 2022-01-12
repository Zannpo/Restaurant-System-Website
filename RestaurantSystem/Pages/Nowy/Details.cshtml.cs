using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RestaurantSystem.Models;

namespace RestaurantSystem.Pages.Nowy_folder
{
    public class DetailsModel : PageModel
    {
        private readonly RestaurantSystem.Models.RamenikDBContext _context;

        public DetailsModel(RestaurantSystem.Models.RamenikDBContext context)
        {
            _context = context;
        }

        public Customer Customer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer = await _context.Customers.FirstOrDefaultAsync(m => m.IdCustomer == id);

            if (Customer == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
