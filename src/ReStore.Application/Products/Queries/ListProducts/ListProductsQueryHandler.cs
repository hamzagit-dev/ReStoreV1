using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ErrorOr;
using MediatR;
using ReStore.Application.Common.Interfaces;
using ReStore.Application.Dtos;

namespace ReStore.Application.Products.Queries.ListProducts
{
       
    public class ListProductsQueryHandler : IRequestHandler<ListProductsQuery, ErrorOr<List<ProductDto>>>
    {
        private readonly IProductsRepository _productsRepository;
        private readonly IMapper _mapper;
          public ListProductsQueryHandler(IProductsRepository productsRepository, IMapper mapper)
          {
            _mapper = mapper;
            _productsRepository = productsRepository;
            
          }
        public async Task<ErrorOr<List<ProductDto>>> Handle(ListProductsQuery request, CancellationToken cancellationToken)
        {
           var products = await _productsRepository.GetAllProductsAsync();
           var resutls= _mapper.Map<List<ProductDto>>(products);
           return resutls;
        }
    }
}