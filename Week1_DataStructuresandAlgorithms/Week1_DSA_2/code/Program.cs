using System;

class Program
{
    static void Main(string[] args)
    {
        double baseValue = 1000.0;
        double rate = 10.0;
        int forecastYears = 3;

        double forecasted = ForecastTool.PredictValue(baseValue, rate, forecastYears);
        Console.WriteLine($"Forecasted Value after {forecastYears} years: {forecasted:F2}");
    }
}
