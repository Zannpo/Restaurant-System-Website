using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RestaurantSystem.Models;

namespace RestaurantSystem.Pages.Order
{
    public class DetailsModel : PageModel
    {
        private readonly RestaurantSystem.Models.RamenikDBContext _context;

        public DetailsModel(RestaurantSystem.Models.RamenikDBContext context)
        {
            _context = context;
        }

        public OrderDetail OrderDetail { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            OrderDetail = await _context.OrderDetails.FirstOrDefaultAsync(m => m.IdOrder == id);

            if (OrderDetail == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
