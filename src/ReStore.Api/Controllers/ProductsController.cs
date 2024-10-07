using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using ReStore.Application.Common.Interfaces;
using ReStore.Application.Dtos;
using ReStore.Application.Products.Queries.ListProducts;
using ReStore.Contracts.Products;
using ReStore.Domain.Products;
using ErrorOr;
using ReStore.Application.Products.Queries.GetProduct;

namespace ReStore.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
       
        private readonly IMediator _mediator;
       
        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
            
           
        }
        [HttpGet]
        public async Task<ActionResult<List<ProductDto>>> GetAllProducts(){
           var productsResult= await _mediator.Send(new ListProductsQuery());

           return  productsResult.Match(products=>Ok(products),error=>Problem());
         
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDto>> GetProduct(int id){
          var query=new GetProductQuery(id);
          var getProductQuery= await _mediator.Send(query);
          return getProductQuery.Match(
            product=>Ok(product),
            error=>Problem()
          );
        }

       
       
    }
}