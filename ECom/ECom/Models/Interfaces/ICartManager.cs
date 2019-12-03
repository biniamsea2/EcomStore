using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECom.Models.Interfaces
{
    public interface ICartManager
    {
        //Create item 
        Task CreateItemAsync(CartItems item);

        //Create cart 
        Task CreateCartAsync(CartItems item);

        //Get individual item
        Task<CartItems> GetItemByIDAsync(int id);

        //Get all items
        Task<List<CartItems>> GetItemsAsync();

        //Update specific item
        Task UpdateItemAsync(CartItems item);

        //Delete specific item
        Task DeleteItemAsync(int id);
    }
}
