public class ForecastTool
{
    public static double PredictValue(double currentValue, double growthRate, int years)
    {
        if (years == 0)
            return currentValue;

        return currentValue + (currentValue * growthRate / 100) + PredictValue(currentValue, growthRate, years - 1);
    }
}
