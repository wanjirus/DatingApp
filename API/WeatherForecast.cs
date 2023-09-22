using System;

namespace API;

public class WeatherForecast
{
    public DateOnly Date { get; set; }

    public int TemperatureC { get; set; }

    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

    public string Summary { get; internal set; }

    private string summary;

    public string GetSummary()
    {
        return summary;
    }

    public void SetSummary(string value)
    {
        summary = value;
    }
}
