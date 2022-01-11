using System;
using System.Collections.Generic;

#nullable disable

namespace RestaurantSystem.Models
{
    public partial class OrderDetail
    {
        public int IdOrder { get; set; }
        public int? IdSpecialOffer { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? OrderTime { get; set; }
        public string OrderStatus { get; set; }
        public string PaymentOption { get; set; }
        public decimal? TotalCost { get; set; }
        public decimal? DeliveryCost { get; set; }
    }
}
