using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReStore.Contracts.Products
{
    public record ListOfProductResponse(List<ProductResponse> products);
   
}