namespace LABA4_SHARPI;

public class Tariff
{
    public double PriceOfTheTariff { get; private set; }

    public Tariff(double priceOfTheTariff) => PriceOfTheTariff = priceOfTheTariff;

    public void PriceUp()
    {
        PriceOfTheTariff++;
    }

    public void PriceDown()
    {
        PriceOfTheTariff--;
    }

    public void PriceUp(double increase)
    {
        PriceOfTheTariff += increase;
    }

    public void PriceDown(double decrease)
    {
        PriceOfTheTariff -= decrease;
    }
}