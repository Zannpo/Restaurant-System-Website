using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using RestaurantSystem.Models;

namespace RestaurantSystem.Pages
{
    public class OrderModel : PageModel
    {
        [BindProperty]
        public OrderDetail CustomersOrder { get; set; }
        [BindProperty]
        public MenuPosition MenuPosition { get; set; }
        [BindProperty(SupportsGet = true)]
        public Customer Customer { get; set; }
                
        public String CustomerName;

        public Boolean Visible = true;

        public Boolean restaurantOpen = true;

        public int currentTime = DateTime.Now.Hour;

        public int openHour = 10;

        public int closeHour = 21;

        public void OnGet()
        {
            if( currentTime >= openHour)
            {
                restaurantOpen = true;
            }
            else
            {
                restaurantOpen = false;
            }

            //Displays the form
            if (string.IsNullOrEmpty(Customer.Name))
            {
                CustomerName = "";
                Visible = false;
            }
            else
            {
                Visible = true;
                // Nothing to do here
            }

        }

        public IActionResult OnPost()
        {
            if(ModelState.IsValid == false)
            {
                return Page();
            }
            else
            {
                CustomerName = Customer.Name;
                return Page();
                //return RedirectToPage("./Index");
            }
        }

       /* public void OnPost()
        {
            //Capture the data from the form

        } */
    }
}
