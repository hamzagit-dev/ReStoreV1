using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ReStore.Domain.Common;

namespace ReStore.Domain.Products
{
    public class Product:Entity
    {
        public string Name{ get; set; }
        public string Description{ get; set; }
         public long  Price { get; set; }   
         public string PictureUrl { get; set; } 
         public string Type { get; set; }   
         public string Brand { get; set; }  
         public int QuantityInStock { get; set; }
         public Product(
             string name,
             string description,
             long price,
             string pictureUrl,
             string type,
             string brand,
             int qunatityInStock
             )
        {
            Name = name;
            Description = description;
            Price = price;
            PictureUrl = pictureUrl;
            Type = type;
            Brand = brand;
            QuantityInStock=qunatityInStock;
        }
        public Product(){}

    }
}