using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StocksApi.DTOs;
using StocksApi.Services;
using StocksApi.Entities;

namespace StocksApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CarsController : ControllerBase
{
    private readonly ICarService _carService;
    private readonly IMapper _mapper;

    public CarsController(ICarService carService, IMapper mapper)
    {
        _carService = carService;
        _mapper = mapper;
    }

    [HttpGet("search")]
    public async Task<IActionResult> SearchCars([FromQuery] CarsFiltersDTO filtersDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        if (filtersDto.MinPrice.HasValue && filtersDto.MaxPrice.HasValue && filtersDto.MinPrice > filtersDto.MaxPrice)
        {
            return BadRequest("Minimum price cannot be greater than maximum price");
        }

        var filters = _mapper.Map<CarFilters>(filtersDto);
        var cars = await _carService.GetCarsAsync(filters);
        return Ok(cars);
    }
}
