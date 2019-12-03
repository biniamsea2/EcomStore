using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ECom.Models;
using ECom.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ECom.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartManager _context;

        public CartController(ICartManager item)
        {
            _context = item;

        }

        public async Task<IActionResult> Index()
        {

            return View(await _context.GetItemsAsync());

        }



        //public async Task<IActionResult> Edit(int id)
        //{
        //    if (id <= 0)
        //    {
        //        return NotFound();
        //    }

        //    var item = await _context.GetItemByIDAsync(id);
        //    if (item == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(item);
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, /*[Bind("Quantity")] */CartItems item)
        //{
        //    if (id != item.ID)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            await _context.UpdateItemAsync(item);
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!await ProductExist(item.ID))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(item);
        //}



        //public async Task<IActionResult> Delete(int id)
        //{
        //    if (id <= 0)
        //    {
        //        return NotFound();
        //    }

        //    var item = await _context.GetItemByIDAsync(id);
        //    return View(item);
        //}


        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    await _context.DeleteItemAsync(id);
        //    return RedirectToAction(nameof(Index));
        //}

        //private async Task<bool> ProductExist(int id)
        //{
        //    CartItems item = await _context.GetItemByIDAsync(id);
        //    if (item != null)
        //    {
        //        return true;
        //    }
        //    return false;
        //}
    }
}