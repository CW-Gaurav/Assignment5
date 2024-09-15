using StocksApi.Enums;
using System.Collections.Generic;

namespace StocksApi.DTOs
{
    public class CarsFiltersDTO
    {
        public int? MinPrice { get; set; } // Nullable int
        public int? MaxPrice { get; set; } // Nullable int
        public List<FuelTypeEnum>? FuelTypes { get; set; } // Nullable List
    }
}
