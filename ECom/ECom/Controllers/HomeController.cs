using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ECom.Controllers
{
    //Home controller will return the index view that we have setup. In our home folder in views.
    
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}