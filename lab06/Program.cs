namespace lab06;

using Task1;

public static class Program
{
    public static void Main()
    {
        var weathers = new List<Weather>();
        while (weathers.Count < 50)
        {
            try
            {
                weathers.Add(OpenWeatherAPI.GetRandomWeather());
            }
            catch (Exception e)
            {
                // Too bad too sad
            }
        }
        
        var lowestTemperature = weathers.Min(w => w.Temperature);
        var highestTemperature = weathers.Max(w => w.Temperature);
        
        var avarageTemperature = weathers.Average(w => w.Temperature);
        
        var countruesNum = weathers.Count();
        
        var fisrtClear = weathers.First(w => w.Description.Equals("clear sky"));
        var firstRain = weathers.First(w => w.Description.Equals("rain"));
        var fisrtFew = weathers.First(w => w.Description.Equals("few clouds"));
    }
}