using AutoMapper;
using Service.Dto;
using Service.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Service.Extensions
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AppUser, UserDto>();
            CreateMap<RegisterDto, AppUser>();

            CreateMap< ProductDto, Products>().ReverseMap();
            //.ForMember(dest => dest.PhotoUrl, opt => opt.MapFrom(src =>
            //  src.Photos.SingleOrDefault(x => x.IsMain).Url));

            //CreateMap<Category, CategoryDto>();
            //CreateMap<ProductInventory, ProductInventoryDto>();
            //CreateMap<ProductInventoryDto, Products>()
            //     .ForMember(dest => dest.ProductInventories, opt => opt.MapFrom(src => src.Product));


        }
    }
}
