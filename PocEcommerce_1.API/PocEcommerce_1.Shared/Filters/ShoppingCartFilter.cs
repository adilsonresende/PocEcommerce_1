﻿namespace PocEcommerce_1.Shared.Filters
{
    public class ShoppingCartFilter : BaseFilter
    {
        public int IdUser { get; set; }
        public int IdProduct { get; set; }
        public DateTime DateAdded { get; set; }
    }
}