using Dapper;
using System.Data;
using StocksApi.Entities;
using StocksApi.Data;

namespace StocksApi.Repositories;

public class CarRepository : ICarRepository
{
    private readonly IDbConnection _dbConnection;

    public CarRepository(IDbConnection dbConnection)
    {
        _dbConnection = dbConnection;
    }

    public async Task<IEnumerable<CarInventory>> GetCarsAsync(CarFilters filters)
    {
        var query = "SELECT * FROM car_inventory WHERE 1=1";

        if (filters.MinPrice.HasValue)
        {
            query += " AND Price >= @MinPrice";
        }

        if (filters.MaxPrice.HasValue)
        {
            query += " AND Price <= @MaxPrice";
        }

        if (filters.FuelTypes != null && filters.FuelTypes.Count > 0)
        {
            query += " AND FuelType IN @FuelTypes";
        }

        return await _dbConnection.QueryAsync<CarInventory>(query, filters);
    }
}
