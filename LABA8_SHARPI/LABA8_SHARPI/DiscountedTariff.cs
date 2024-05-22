namespace LABA8_SHARPI;

public class DiscountedTariff : IPrice
{
    private double cost;
    private double discount;

    public DiscountedTariff(double cost, double discount)
    {
        this.cost = cost;
        this.discount = discount;
    }

    public double GetPrice()
    {
        return cost * (1 - discount);
    }
}