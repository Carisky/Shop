using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Shop.Filters;
using Shop.Models;

namespace Shop.Controllers
{
    public class StoreController : Controller
    {
        private static List<Product> _products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "Product 1",
                Price = 10.0m
            },
            new Product
            {
                Id = 2,
                Name = "Product 2",
                Price = 20.0m
            },
            new Product
            {
                Id = 3,
                Name = "Product 3",
                Price = 30.0m
            }
        };

        public IActionResult Index()
        {
            return View(_products);
        }

        [HttpGet]
        [ServiceFilter(typeof(SearchLoggingFilter))]
        public IActionResult Search(string searchTerm)
        {
            var results = _products.Where(p => p.Name.Contains(searchTerm)).ToList();
            return View(results);
        }
    }
}
