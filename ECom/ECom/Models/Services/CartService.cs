using ECom.Data;
using ECom.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECom.Models.Services
{
    public class CartService: ICartManager
    {
        private StoreDbContext _context;
        public CartService(StoreDbContext context)
        {
            _context = context;
        }

        public Task CreateCartAsync(CartItems item)
        {
            
        }

        public Task CreateItemAsync(CartItems item)
        {

        }

        public async Task DeleteItemAsync(int id)
        {
            CartItems item = await GetItemByIDAsync(id);
            _context.CartItems.Remove(item);
            await _context.SaveChangesAsync();
        }

        public async Task<CartItems> GetItemByIDAsync(int id) => await _context.CartItems.FirstOrDefaultAsync(it1 => it1.ID == id);

        public async Task<List<CartItems>> GetItemsAsync()
        {
            List<CartItems> items = await _context.CartItems.ToListAsync();
            return items;
        }

        public async Task UpdateItemAsync(CartItems items)
        {
            _context.CartItems.Update(items);
            await _context.SaveChangesAsync();
        }
    }
}
