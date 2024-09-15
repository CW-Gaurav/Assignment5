using StocksApi.Entities;

namespace StocksApi.Repositories;

public interface ICarRepository
{
    Task<IEnumerable<CarInventory>> GetCarsAsync(CarFilters filters);
}
