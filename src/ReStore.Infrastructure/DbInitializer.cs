using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReStore.Domain.Products;
using ReStore.Infrastructure.Common.Persistence;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

namespace ReStore.Infrastructure
{
    public static class InitialiserExtensions
    {
        public static async Task InitialiseDatabaseAsync(this WebApplication app)
        {
            using var scope = app.Services.CreateScope();

            var initialiser = scope.ServiceProvider.GetRequiredService<DbInitializer>();

            await initialiser.InitialiseAsync();

            initialiser.Seed();
        }
    }
    public class DbInitializer
    {
        private readonly ReStoreDbContext _context;
        public ILogger<DbInitializer> _logger { get; }
     
        public DbInitializer(ReStoreDbContext context, ILogger<DbInitializer> logger)
        {
           
            _logger = logger;
            _context = context;
        }

        public async Task InitialiseAsync()
        {
            try
            {
                await _context.Database.MigrateAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while initialising the database.");
                throw;
            }
        }

        public void Seed()
        {

            // context.Database.EnsureCreated();
            if (!_context.Products.Any())
            {
                var products = new List<Product>
            {

            new Product {
                Name = "Angular Speedster Board 2000",
                Description =
                    "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                Price = 20000,
                PictureUrl = "/images/products/sb-ang1.png",
                Brand = "Angular",
                Type = "Boards",
                QuantityInStock = 100
            },
            new Product
            {
                Name = "Green Angular Board 3000",
                Description = "Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.",
                Price = 15000,
                PictureUrl = "/images/products/sb-ang2.png",
                Brand = "Angular",
                Type = "Boards",
                QuantityInStock = 100
            },
            new Product
            {
                Name = "Core Board Speed Rush 3",
                Description =
                    "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                Price = 18000,
                PictureUrl = "/images/products/sb-core1.png",
                Brand = "NetCore",
                Type = "Boards",
                QuantityInStock = 100
            },
            new Product
            {
                Name = "Net Core Super Board",
                Description =
                    "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                Price = 30000,
                PictureUrl = "/images/products/sb-core2.png",
                Brand = "NetCore",
                Type = "Boards",
                QuantityInStock = 100
            },
            new Product
            {
                Name = "React Board Super Whizzy Fast",
                Description =
                    "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                Price = 25000,
                PictureUrl = "/images/products/sb-react1.png",
                Brand = "React",
                Type = "Boards",
                QuantityInStock = 100
            },
            new Product
            {
                Name = "Typescript Entry Board",
                Description =
                    "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                Price = 12000,
                PictureUrl = "/images/products/sb-ts1.png",
                Brand = "TypeScript",
                Type = "Boards",
                QuantityInStock = 100
            },
            new Product
            {
                Name = "Core Blue Hat",
                Description =
                    "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                Price = 1000,
                PictureUrl = "/images/products/hat-core1.png",
                Brand = "NetCore",
                Type = "Hats",
                QuantityInStock = 100
            },
            new Product
            {
                Name = "Green React Woolen Hat",
                Description =
                    "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                Price = 8000,
                PictureUrl = "/images/products/hat-react1.png",
                Brand = "React",
                Type = "Hats",
                QuantityInStock = 100
            },
            new Product
            {
                Name = "Purple React Woolen Hat",
                Description =
                    "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                Price = 1500,
                PictureUrl = "/images/products/hat-react2.png",
                Brand = "React",
                Type = "Hats",
                QuantityInStock = 100
            },
            new Product
            {
                Name = "Blue Code Gloves",
                Description =
                    "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                Price = 1800,
                PictureUrl = "/images/products/glove-code1.png",
                Brand = "VS Code",
                Type = "Gloves",
                QuantityInStock = 100
            },
            new Product
            {
                Name = "Green Code Gloves",
                Description =
                    "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                Price = 1500,
                PictureUrl = "/images/products/glove-code2.png",
                Brand = "VS Code",
                Type = "Gloves",
                QuantityInStock = 100
            },
            new Product
            {
                Name = "Purple React Gloves",
                Description =
                    "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                Price = 1600,
                PictureUrl = "/images/products/glove-react1.png",
                Brand = "React",
                Type = "Gloves",
                QuantityInStock = 100
            },
            new Product
            {
                Name = "Green React Gloves",
                Description =
                    "Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                Price = 1400,
                PictureUrl = "/images/products/glove-react2.png",
                Brand = "React",
                Type = "Gloves",
                QuantityInStock = 100
            },
            new Product
            {
                Name = "Redis Red Boots",
                Description =
                    "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                Price = 25000,
                PictureUrl = "/images/products/boot-redis1.png",
                Brand = "Redis",
                Type = "Boots",
                QuantityInStock = 100
            },
            new Product
            {
                Name = "Core Red Boots",
                Description =
                    "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus malesuada libero, sit amet commodo magna eros quis urna.",
                Price = 18999,
                PictureUrl = "/images/products/boot-core2.png",
                Brand = "NetCore",
                Type = "Boots",
                QuantityInStock = 100
            },
            new Product
            {
                Name = "Core Purple Boots",
                Description =
                    "Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.",
                Price = 19999,
                PictureUrl = "/images/products/boot-core1.png",
                Brand = "NetCore",
                Type = "Boots",
                QuantityInStock = 100
            },
            new Product
            {
                Name = "Angular Purple Boots",
                Description = "Aenean nec lorem. In porttitor. Donec laoreet nonummy augue.",
                Price = 15000,
                PictureUrl = "/images/products/boot-ang2.png",
                Brand = "Angular",
                Type = "Boots",
                QuantityInStock = 100
            },
            new Product
            {
                Name = "Angular Blue Boots",
                Description =
                    "Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc. Mauris eget neque at sem venenatis eleifend. Ut nonummy.",
                Price = 18000,
                PictureUrl = "/images/products/boot-ang1.png",
                Brand = "Angular",
                Type = "Boots",
                QuantityInStock = 100
            }
        };
                _context.Products.AddRange(products);
                _context.SaveChanges();

            }
        }
    }
}