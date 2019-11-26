using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECom.Models;
using ECom.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ECom.Pages.Show
{
    public class detailsModel : PageModel
    {
        //add the id as a parameter in order to get the details of a specific product.
        
            private readonly IInventory _context;
            public detailsModel(IInventory context)
            {
                _context = context;
            }
            public Product Product { get; set; }

            public async Task OnGet(int id)
            {
                Product = await _context.GetProductByIDAsync(id);
            }
        }
    }