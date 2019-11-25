using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ECom.Pages.Show
{
    public class detailsModel : PageModel
    {
        //add the id as a parameter in order to get the details of a specific product.
        public void OnGet(int id)
        {

        }
    }
}