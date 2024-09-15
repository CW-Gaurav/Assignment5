using StocksApi.DTOs;
using StocksApi.Entities;

namespace StocksApi.Services;

public interface ICarService
{
    Task<IEnumerable<CarDetailsDTO>> GetCarsAsync(CarFilters filters);
}
