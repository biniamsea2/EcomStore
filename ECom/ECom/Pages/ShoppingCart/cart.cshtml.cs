using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECom.Models;
using ECom.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ECom.Pages.ShoppingCart
{
    public class CartModel : PageModel
    {
        private readonly ICartManager _context;

        public CartModel(ICartManager context)
        {
            _context = context;
        }


        public IEnumerable<CartItems> TestItem { get; set; }

        public async Task OnGet(string CartId)
        {
            TestItem = await _context.GetItemsAsync(CartId);
        }


        public  void OnPost()
        {
        }
    }
}