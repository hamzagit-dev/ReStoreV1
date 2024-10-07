using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReStore.Contracts.Products
{
    public record ProductResponse(string Name,
             string Description,
             long Price,
             string PictureUrl,
             string Type,
             string Brand,
             int QunatityInStock);
    
}