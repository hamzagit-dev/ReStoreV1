using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ErrorOr;
using MediatR;
using ReStore.Application.Dtos;

namespace ReStore.Application.Products.Queries.ListProducts
{
    public record ListProductsQuery:IRequest<ErrorOr<List<ProductDto>>>;
   
}