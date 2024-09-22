namespace lab03.Task3;

public class CurrencyRUB : Currency
{
    public CurrencyRUB(double value = 0) : base(value) { }

    public static explicit operator CurrencyRUB(CurrencyUSD v)
    {
        return new CurrencyRUB(v.Value / Rates.USD * Rates.RUB);
    }

    public static explicit operator CurrencyRUB(CurrencyEUR v)
    {
        return new CurrencyRUB(v.Value / Rates.EUR * Rates.RUB);
    }
}