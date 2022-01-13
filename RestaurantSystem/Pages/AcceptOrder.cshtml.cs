using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RestaurantSystem.Models;

namespace RestaurantSystem.Pages
{
    public class AcceptOrderModel : PageModel
    {
        [BindProperty]
        public OrderDetail CustomersOrder { get; set; }
        [BindProperty]
        public MenuPosition MenuPosition { get; set; }
        [BindProperty(SupportsGet = true)]
        public Customer Customer { get; set; }

        public String CustomerName;

        public int currentTime = DateTime.Now.Hour;

        public void OnGet(String customerName)
        {
            CustomerName = customerName;
        }
    }
}
