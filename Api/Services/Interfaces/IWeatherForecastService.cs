using Api.Services.Models;
using Data.Models;

namespace Api.Services.Interfaces;

public interface IWeatherForecastService
{
    public Task<OpenMeteoModel> GetWeatherForcast(Location location);
}