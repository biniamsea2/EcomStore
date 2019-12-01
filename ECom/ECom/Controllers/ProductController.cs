using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECom.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ECom.Controllers
{
    /// <summary>
    /// we have a dependency injection with our IInventory interface. It includes an index with a return of view that 
    /// we have created in our pages folder
    /// </summary>
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


        // only allow authorized users to be able to get the rest of these actions 
    }
}