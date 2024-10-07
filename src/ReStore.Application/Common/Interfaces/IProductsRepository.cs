using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReStore.Domain.Products;

namespace ReStore.Application.Common.Interfaces
{
    public interface IProductsRepository
    {
        Task<List<Product>> GetAllProductsAsync();  
        Task<Product?>GetByIdAsync(int id);
    }
}