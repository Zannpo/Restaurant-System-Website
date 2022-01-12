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
    public class IndexModel : PageModel
    {
        private readonly RestaurantSystem.Models.RamenikDBContext _context;

        public IndexModel(RestaurantSystem.Models.RamenikDBContext context)
        {
            _context = context;
        }

        public IList<OrderDetail> OrderDetail { get;set; }

        public async Task OnGetAsync()
        {
            OrderDetail = await _context.OrderDetails.ToListAsync();
        }
    }
}
