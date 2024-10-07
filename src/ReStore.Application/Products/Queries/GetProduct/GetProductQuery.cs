using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ErrorOr;
using MediatR;
using ReStore.Application.Dtos;

namespace ReStore.Application.Products.Queries.GetProduct
{
    public record GetProductQuery(int Id):IRequest<ErrorOr<ProductDto>>;
  
}