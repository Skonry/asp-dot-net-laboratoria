using lab5.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab5.Controllers
{
    public class ProductsController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(ProductModel product)
        {
            var viewModel = new ProductsStatsViewModel
            {
                NameLength = product.Name.Length
            };

            return View(viewModel);
        }
    }
}
