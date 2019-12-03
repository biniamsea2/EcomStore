using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity.UI.Services;


namespace ECom.Controllers
{
    //Home controller will return the index view that we have setup. In our home folder in views.
    
    public class HomeController : Controller
    {
        private IEmailSender _email;

        public HomeController(IEmailSender email)
        public IActionResult Index()
        {
            return View();
        }
    }
}