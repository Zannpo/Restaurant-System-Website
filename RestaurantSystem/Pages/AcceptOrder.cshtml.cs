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

        public String CustomerName, CustomerSurname, CustomerAddress, CustomerEmail, CustomerPhone;

        public List<Customer> CustomerData = new List<Customer>();

        RamenikDBContext context = new RamenikDBContext();

        public void OnGet(String customerName, String customerSurname, String customerAddress, String customerEmail, String customerPhone)
        {
            CustomerName = customerName;
            CustomerSurname = customerSurname;
            CustomerAddress = customerAddress;
            CustomerEmail = customerEmail;
            CustomerPhone = customerPhone;

            CustomerData.Add(Customer);
        }
        public IActionResult OnPost() 
        {
            
            //context.Customers.Add(Customer);
            //context.SaveChanges();


            ViewData["Message"] = string.Format("Udalo sie zlozyc zamowienie!");

            
            return RedirectToPage("Index");
        }
    }
}
