using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ErrorOr;
using MediatR;
using ReStore.Application.Common.Interfaces;
using ReStore.Application.Dtos;

namespace ReStore.Application.Products.Queries.GetProduct
{
    public class GetProductQueryHandler : IRequestHandler<GetProductQuery, ErrorOr<ProductDto>>
    {
        private readonly IProductsRepository _productsRepository;
        private readonly IMapper _mapper;
        public GetProductQueryHandler(IProductsRepository productsRepository,IMapper mapper)
        {
            _mapper = mapper;
            _productsRepository = productsRepository;
            
        }
        public async Task<ErrorOr<ProductDto>> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            var product= await _productsRepository.GetByIdAsync(request.Id);
            return product is null 
                   ? Error.NotFound( description:"Product Not found")
                   : _mapper.Map<ProductDto>(product);
        }
    }
}