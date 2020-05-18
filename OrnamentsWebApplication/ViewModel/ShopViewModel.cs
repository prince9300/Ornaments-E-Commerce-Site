﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ornaments.Model.Model;
using OrnamentsWebApplication.Models;

namespace OrnamentsWebApplication.ViewModel
{
    public class CheckoutViewModel
    {
        public List<Product> CartProducts { get; set; }

        public List<int> CartProductsIds { get; set; }

        public ApplicationUser User { get; set; }
    }

    public class ShopViewModel
    {
        

        public int MaximumPrice { get; set; }
        public List<Product> Products { get; set; }
        public List<Category> FeaturedCategories { get; set; }
        public int? SortBy { get; set; }

        public int? CategoryId { get; set; }

        public Pager Pager { get; set; }
        public string SearchTerm { get; set; }
    }

    public class PriceFilteringViewModel
    {
        public List<Product> Products { get; set; }
        public Pager Pager { get; set; }
        public int? SortBy { get; set; }
        public int? CategoryId { get; set; }
        public string SearchTerm { get; set; }
    }
}