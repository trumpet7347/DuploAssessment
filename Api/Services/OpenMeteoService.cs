using Api.Services.Interfaces;
using Api.Services.Models;
using Data.Models;
using Data.Repositories.Interfaces;
using Newtonsoft.Json;

namespace Api.Services;

public class OpenMeteoService: IWeatherForecastService
{
    private const string OpenMeteoBaseUri = "https://api.open-meteo.com/v1/forecast";
    public async Task<OpenMeteoModel> GetWeatherForcast(Location location)
    {
        using var client = new HttpClient();
        
        var response =
            await client.GetAsync( OpenMeteoBaseUri + $"?latitude={location.Latitude}&longitude={location.Longitude}&current=temperature_2m,relativehumidity_2m,precipitation,windspeed_10m,winddirection_10m");

        return JsonConvert.DeserializeObject<OpenMeteoModel>(await response.Content.ReadAsStringAsync());

    }
}