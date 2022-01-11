using System;
using System.Collections.Generic;

#nullable disable

namespace RestaurantSystem.Models
{
    public partial class SpecialOffer
    {
        public int IdSpecialOffer { get; set; }
        public string SpecialOfferName { get; set; }
        public string SpecialOfferDescription { get; set; }
    }
}
