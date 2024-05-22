namespace LABA8_SHARPI;

public class ATS
{
    private List<Tariff> lstTariffs;

    public ATS()
    {
        lstTariffs = new List<Tariff>();
    }

    public void AddRegularTariff(string name, double cost)
    {
        IPrice regularPrice = new RegularTariff(cost);
        Tariff tariff = new Tariff(name, regularPrice);
        lstTariffs.Add(tariff);
    }

    public void AddDiscountedTariff(string name, double cost, double discount)
    {
        IPrice discountedPrice = new DiscountedTariff(cost, discount);
        Tariff tariff = new Tariff(name, discountedPrice);
        lstTariffs.Add(tariff);
    }

    public double CalculateAverageCost()
    {
        if (lstTariffs.Count == 0) return 0.0;

        double totalCost = 0.0;
        foreach (var tariff in lstTariffs)
        {
            totalCost += tariff.GetPrice();
        }
        return totalCost / lstTariffs.Count;
    }
}