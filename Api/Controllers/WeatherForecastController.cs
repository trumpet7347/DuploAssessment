using Api.Services.Interfaces;
using Api.Services.Models;
using Data.Models;
using Data.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly ILocationsRepository _locationsRepository;
    private readonly IWeatherForecastService _weatherForecastService;

    public WeatherForecastController(ILocationsRepository locationsRepository, IWeatherForecastService weatherForecastService)
    {
        _locationsRepository = locationsRepository;
        _weatherForecastService = weatherForecastService;
    }

    [HttpGet("{locationId}")]
    public async Task<ActionResult<OpenMeteoModel>> Get(int locationId)
    {
        var location = await _locationsRepository.GetLocation(locationId);

        if (location == null)
        {
            return NotFound($"No Location with ID {locationId}");
        }

        return Ok(await _weatherForecastService.GetWeatherForcast(location));
    }
}