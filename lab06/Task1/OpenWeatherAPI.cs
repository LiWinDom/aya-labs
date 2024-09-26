namespace lab06.Task1;

using System.Text.Json;

public static class OpenWeatherAPI
{
    private record OpenWeather
    {
        public record Coord
        {
            public double lon { get; init; }
            public double lat { get; init; }
        }
        public Coord coord { get; init; }

        public record Weather
        {
            public int id { get; init; }
            public string main { get; init; }
            public string description { get; init; }
            public string icon { get; init; }
        }
        public Weather[] weather { get; init; }

        public record Main
        {
            public double temp { get; init; }
            public double feels_like { get; init; }
            public double temp_min { get; init; }
            public double temp_max { get; init; }
            public int pressure { get; init; }
            public int humidity { get; init; }
            public int sea_level { get; init; }
            public int grnd_level { get; init; }
        }
        public Main main { get; init; }
        
        public int visibility { get; init; }

        public record Wind
        {
            public double speed { get; init; }
            public int deg { get; init; }
            public double gust { get; init; }
        }
        public Wind wind { get; init; }

        public record Rain
        {
            public double one_h { get; init; }
        }
        public Rain rain { get; init; }

        public record Clouds
        {
            public int all { get; init; }
        }
        public Clouds clouds { get; init; }

        public int dt;

        public record Sys
        {
            public int type { get; init; }
            public int id { get; init; }
            public string country { get; init; }
            public int sunrise { get; init; }
            public int sunset { get; init; }
        }
        public Sys sys { get; init; }
        
        public int timezone { get; init; }
        public int id { get; init; }
        public string name { get; init; }
        public int cod { get; init; }
    }
    
    static OpenWeatherAPI()
    {
        Client = new HttpClient()
        {
            BaseAddress = new Uri("https://api.openweathermap.org/data/2.5/"),
        };
    }
    
    public static Weather GetRandomWeather()
    {
        double lat = Random.Shared.NextDouble() * 180 - 90;
        double lon = Random.Shared.NextDouble() * 360 - 180;
        var response = Client.GetAsync($"weather?lat={lat}&lon={lon}&appid={ApiKey}").Result;

        if (!response.IsSuccessStatusCode)
        {
            throw new HttpRequestException($"Unable to get open weather data. Status Code: {response.StatusCode}");
        }
        
        var jsonResponse = JsonSerializer.Deserialize<OpenWeather>(response.Content.ReadAsStringAsync().Result);

        if (jsonResponse.sys.country == null || jsonResponse.name == null)
        {
            throw new HttpRequestException($"Random country or name not found");
        }

        return new Weather()
        {
            Temperature = jsonResponse.main.temp,
            City = jsonResponse.name,
            Country = jsonResponse.sys.country,
            Description = jsonResponse.weather[0].description,
        };
    }

    private static readonly HttpClient Client;
    private const string ApiKey = "fc79b00e0e3038f662f49c5331254e89"; // Never do it like this
}