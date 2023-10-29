using Newtonsoft.Json;

namespace Api.Services.Models;

public class OpenMeteoModel
{
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    
    [JsonProperty("generationtime_ms")]
    public double GenerationTimeMs { get; set; }
    
    [JsonProperty("utc_offset_seconds")]
    public int UtcOffsetSeconds { get; set; }
    public string Timezone { get; set; }
    
    [JsonProperty("timezone_abbreviation")]
    public string TimezoneAbbreviation { get; set; }
    public double Elevation { get; set; }
    
    [JsonProperty("current_units")]
    public CurrentUnits CurrentUnits { get; set; }
    public Current Current { get; set; }
}

public class CurrentUnits
{
    public string Time { get; set; }
    public string Interval { get; set; }
    
    [JsonProperty("temperature_2m")]
    public string Temperature2m { get; set; }
    
    [JsonProperty("relativehumidity_2m")]
    public string RelativeHumidity2m { get; set; }
    
    [JsonProperty("precipitation")]
    public string Precipitation { get; set; }
    
    [JsonProperty("windspeed_10m")]
    public string WindSpeed10m { get; set; }
    
    [JsonProperty("winddirection_10m")]
    public string WindDirection10m { get; set; }
}

public class Current
{
    public string Time { get; set; }
    public int Interval { get; set; }
    
    [JsonProperty("temperature_2m")]
    public double Temperature2m { get; set; }
    
    [JsonProperty("relativehumidity_2m")]
    public int RelativeHumidity2m { get; set; }
    
    [JsonProperty("precipitation")]
    public double Precipitation { get; set; }
    
    [JsonProperty("windspeed_10m")]
    public double WindSpeed10m { get; set; }
    
    [JsonProperty("winddirection_10m")]
    public int WindDirection10m { get; set; }
}