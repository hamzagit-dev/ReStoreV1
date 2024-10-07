using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bogus;

namespace ReStore.Domain.Products
{
    public class ProductFaker
    {
         public static Faker<Product> GetProductFaker()
    {
        return new Faker<Product>()
            .RuleFor(p => p.Id, f => 0) // Id will be set by the database
            .RuleFor(p => p.Name, f => f.Commerce.ProductName())
            .RuleFor(p=>p.Description,f=>f.Commerce.ProductDescription())
            .RuleFor(p=>p.PictureUrl,f=>f.Image.PicsumUrl())
            .RuleFor(p => p.Price,f=>long.Parse(f.Commerce.Price()))
            .RuleFor(p=>p.Brand,f=>f.Company.CompanyName());
            
    }
    }
}