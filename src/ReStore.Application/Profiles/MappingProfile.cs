using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ReStore.Application.Dtos;
using ReStore.Domain.Products;

namespace ReStore.Application.Profiles
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Product,ProductDto>().ReverseMap();
        }
    }
}