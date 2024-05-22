namespace LABA8_SHARPI;

public class RegularTariff : IPrice
{
    private double cost;

    public RegularTariff(double cost)
    {
        this.cost = cost;
    }

    public double GetPrice()
    {
        return cost;
    }
}