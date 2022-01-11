using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.Sqlite;
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

        void refresh()
        {
            var connectionStringBuilder = new SqliteConnectionStringBuilder();
            connectionStringBuilder.DataSource = "RestaurantSystem\\wwwroot\\resources\\ramenik.db";

            using (var databaseConnection = new SqliteConnection(connectionStringBuilder.ConnectionString))
            {
                databaseConnection.Open();

                var selectCmd = databaseConnection.CreateCommand();
                selectCmd.CommandText = "SELECT specialOfferName FROM SecialOffer";

                using (var reader = selectCmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        SpecialOffer.specialOfferName = reader.GetString(0);
                        
                    }                    
                }
            }
        }               
    }
   
}
