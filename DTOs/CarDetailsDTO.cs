namespace StocksApi.DTOs
{
    public class CarDetailsDTO
    {
        public int Id { get; set; } = 0; // Default value for int is 0
        public string? CarName { get; set; } // Nullable reference type
        public string? FormattedPrice { get; set; } // Nullable reference type
        public string? FuelType { get; set; } // Nullable reference type
        public bool IsValueForMoney { get; set; } = false; // Default value for bool is false
    }
}
