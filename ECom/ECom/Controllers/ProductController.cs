using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECom.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ECom.Controllers
{
    public class ProductController : Controller
    {
        private readonly IInventory _context;

        public ProductController(IInventory product)
        {
            _context = product;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}