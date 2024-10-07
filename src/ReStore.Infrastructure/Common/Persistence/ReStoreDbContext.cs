using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReStore.Application.Common.Interfaces;
using ReStore.Domain.Products;

namespace ReStore.Infrastructure.Common.Persistence
{
    public class ReStoreDbContext : DbContext,IUnitOfWork
    {
        public ReStoreDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }=null!;

        public async Task CommitChangesAsync()
        {
           await SaveChangesAsync();
        }
    }
}