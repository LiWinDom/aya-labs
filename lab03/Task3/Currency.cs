namespace lab03.Task3;

public static class Rates
{
    public const double USD = 1;
    public const double EUR = 0.90;
    public const double RUB = 92.75;
}

public abstract class Currency
{
    public Currency(double value = 0)
    {
        Value = value;
    }

    public double Value { get; set; }
}