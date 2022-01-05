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
    public class SpecialOffersModel : PageModel
    {
        [BindProperty]
        public SpecialOfferModel SpecialOffer { get; set; }

        [BindProperty(SupportsGet = true)] //BindProperty makes it writable
        public int Id { get; set; }

        public void OnGet()
        {
            

        }
               
    }
}
