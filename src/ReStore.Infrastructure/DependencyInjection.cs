using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ReStore.Application.Common.Interfaces;
using ReStore.Infrastructure.Common.Persistence;
using ReStore.Infrastructure.Products;

namespace ReStore.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration){
            services.AddDbContext<ReStoreDbContext>(options=>options.UseSqlite(configuration.GetConnectionString("DefaultConnection")));
           //services.AddScoped<IApplicationDbContext>(provider => provider.GetRequiredService<ApplicationDbContext>());
           services.AddScoped<ReStoreDbContext>();
            services.AddScoped<DbInitializer>();
            services.AddScoped<IProductsRepository,ProductsRepository>();
            services.AddScoped<IUnitOfWork>(serviceProvider=>serviceProvider.GetRequiredService<ReStoreDbContext>());
          return services;
        }
    }
}