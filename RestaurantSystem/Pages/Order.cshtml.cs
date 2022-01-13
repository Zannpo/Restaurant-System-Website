using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using RestaurantSystem.Models;

namespace RestaurantSystem.Pages
{
    public class OrderModel : PageModel
    {
        [BindProperty]
        public OrderDetail CustomersOrder { get; set; }

        [BindProperty]
        public OrderPosition CustomersOrderPosition { get; set; }

        [BindProperty]
        public MenuPosition MenuPosition { get; set; }
        [BindProperty(SupportsGet = true)]
        public Customer Customer { get; set; }
                
        public String CustomerName, CustomerSurname,CustomerAddress, CustomerEmail, CustomerPhone;

        public Boolean Visible = true;

        public Boolean restaurantOpen = true;

        public int currentTime = DateTime.Now.Hour;

        public int openHour = 10;

        public int closeHour = 21;

        RamenikDBContext context = new RamenikDBContext();
        public SelectList Courses { get; set; }

        public List<MenuPosition> AllPositions = new List<MenuPosition>();

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

           
           var dishes = from dish in context.MenuPositions
                             select dish.CourseName;

            Courses = new SelectList(dishes);
            

        }

        public IActionResult OnPost()
        {
            if(ModelState.IsValid == false)
            {
                return Page();
            }
            else
            {
                /*RamenikDBContext context = new RamenikDBContext();

                CustomerName = Customer.Name;
                //return Page();

                context.OrderDetails.Add(CustomersOrder);
                context.Customers.Add(Customer);
                context.SaveChanges();
                
                return RedirectToPage("./Order/Index"); */
                CustomerName = Customer.Name;
                CustomerSurname = Customer.Surname;
                CustomerEmail = Customer.Email;
                CustomerAddress = Customer.Address;
                CustomerPhone = Customer.PhoneNumber;
                return RedirectToPage("AcceptOrder", new {CustomerName, CustomerSurname, CustomerAddress, CustomerEmail, CustomerPhone });

            }
        }

       /*public async Task<IActionResult> OnPostAsync()
        {
            RamenikDBContext context = new RamenikDBContext();
            context.OrderDetails.Add(CustomersOrder);
            await context.SaveChangesAsync();
            return RedirectToPage("./Order/Index");
        } */
    }
}
