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
        public OrderDetailsModel CustomersOrder { get; set; }
        [BindProperty]
        public MenuPositionModel MenuPosition { get; set; }
        [BindProperty(SupportsGet = true)]
        public CustomerModel Customer { get; set; }
                
        public String CustomerName;

        public Boolean Visible = true;

        public void OnGet()
        {
            
            //Displays the form
            if (string.IsNullOrEmpty(Customer.name))
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
                CustomerName = Customer.name;
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
