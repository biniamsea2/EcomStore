using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECom.Models.Interfaces
{
    public interface IInventory 
    {
        //Create product 
        Task CreateProductAsync(Product product);

        //Get individual product
        Task<Product> GetProductByIDAsync(int id);

        //Get all products
        Task<List<Product>> GetProductsAsync();

        //Update specific product
        Task UpdateProductAsync(Product product);

        //Delete specific product
        Task DeleteProductAsync(int id);
    }
}
