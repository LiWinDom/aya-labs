namespace lab03.Task3;

public class CurrencyUSD : Currency
{
    public CurrencyUSD(double value = 0) : base(value) { }

    public static explicit operator CurrencyUSD(CurrencyEUR v)
    {
        return new CurrencyUSD(v.Value / Rates.EUR * Rates.USD);
    }

    public static explicit operator CurrencyUSD(CurrencyRUB v)
    {
        return new CurrencyUSD(v.Value / Rates.RUB * Rates.USD);
    }
}
