using AutoMapper;
using StocksApi.DTOs;
using StocksApi.Entities;

namespace StocksApi.Configurations;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<CarsFiltersDTO, CarFilters>()
            .ForMember(dest => dest.MinPrice, opt => opt.MapFrom(src => src.MinPrice.HasValue ? src.MinPrice * 100000 : (int?)null))
            .ForMember(dest => dest.MaxPrice, opt => opt.MapFrom(src => src.MaxPrice.HasValue ? src.MaxPrice * 100000 : (int?)null));

        CreateMap<CarInventory, CarDetailsDTO>()
            .ForMember(dest => dest.CarName, opt => opt.MapFrom(src => $"{src.Year} {src.Make} {src.Model}"))
            .ForMember(dest => dest.FormattedPrice, opt => opt.MapFrom(src => $"{src.Price / 100000} Lakhs"))
            .ForMember(dest => dest.IsValueForMoney, opt => opt.MapFrom(src => src.KilometersDriven < 10000 && src.Price < 200000));
    }
}
