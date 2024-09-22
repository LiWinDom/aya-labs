namespace lab03.Task3;

public class CurrencyEUR : Currency
{
    public CurrencyEUR(double value = 0) : base(value) { }

    public static explicit operator CurrencyEUR(CurrencyUSD v)
    {
        return new CurrencyEUR(v.Value / Rates.USD * Rates.EUR);
    }

    public static explicit operator CurrencyEUR(CurrencyRUB v)
    {
        return new CurrencyEUR(v.Value / Rates.RUB * Rates.EUR);
    }
}