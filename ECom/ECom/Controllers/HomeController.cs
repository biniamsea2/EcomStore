using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity.UI.Services;
using System.Text;
using ECom.Models;

namespace ECom.Controllers
{
    //Home controller will return the index view that we have setup. In our home folder in views.
    
    public class HomeController : Controller
    {
        private IEmailSender _email;

        public HomeController(IEmailSender email)
        {
            _email = email;
        }
        public IActionResult Index()
        {
            Email newEmail = ConstructEmail();

            _email.SendEmailAsync(newEmail.ToEmail, newEmail.Subject, newEmail.Message);
            return View();
        }
        private Email ConstructEmail()
        {
            StringBuilder sb = new StringBuilder();


        }
    }
}