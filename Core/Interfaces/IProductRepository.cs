using Core.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
   public  interface IProductRepository
    {
        Task<IEnumerable<product>> GetAllProductAsync();

        Task<product> GetProductByIdAsync(int id);

        Task<product> CreateProductAsync(product product);

        Task UpdateProductAsync(int id, product product);

        Task DeleteProductByIdAsync(int id);
    }
}
