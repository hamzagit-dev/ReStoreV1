using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReStore.Application.Common.Interfaces;
using ReStore.Domain.Products;
using ReStore.Infrastructure.Common.Persistence;

namespace ReStore.Infrastructure.Products
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly ReStoreDbContext _dbContext;
        public ProductsRepository(ReStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Product>> GetAllProductsAsync()
        {
            return await _dbContext.Products.ToListAsync();
        }

        public async Task<Product?> GetByIdAsync(int id)
        {
           return await _dbContext.Products.SingleOrDefaultAsync(p=>p.Id==id);
        }
    }
}