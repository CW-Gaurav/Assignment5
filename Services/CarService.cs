using AutoMapper;
using StocksApi.DTOs;
using StocksApi.Repositories;
using StocksApi.Entities;

namespace StocksApi.Services;

public class CarService : ICarService
{
    private readonly ICarRepository _carRepository;
    private readonly IMapper _mapper;

    public CarService(ICarRepository carRepository, IMapper mapper)
    {
        _carRepository = carRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<CarDetailsDTO>> GetCarsAsync(CarFilters filters)
    {
        var cars = await _carRepository.GetCarsAsync(filters);
        return _mapper.Map<IEnumerable<CarDetailsDTO>>(cars);
    }
}
