using StocksApi.Enums;

namespace StocksApi.Entities;

public class CarInventory
{
    public int Id { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public decimal Price { get ; set; }
    public int KilometersDriven { get; set; }
    public FuelTypeEnum FuelType { get; set; }
}
