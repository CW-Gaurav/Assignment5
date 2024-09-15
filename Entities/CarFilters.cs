using StocksApi.Enums;

namespace StocksApi.Entities;

public class CarFilters
{
    public int? MinPrice { get; set; }
    public int? MaxPrice { get; set; }
    public List<FuelTypeEnum>? FuelTypes { get; set; }
}
