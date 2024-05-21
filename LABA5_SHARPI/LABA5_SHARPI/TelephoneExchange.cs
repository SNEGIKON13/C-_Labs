namespace LABA5_SHARPI;

public class TelephoneExchange
{
    public List<Tariffs> TariffsList { get; set; } = [];
    public List<Clients> ClientsList { get; set; } = [];

    public double CalculateClientCost(Clients client)
    {
        double clientCost = 0;

        foreach (var tariffOfCallsPerArea in client.NumberOfCallsPerArea)
        {
            var tariff = TariffsList.Find(t => t.Area == tariffOfCallsPerArea.Key);
            if (tariff != null) clientCost += tariff.Price * tariffOfCallsPerArea.Value;
        }

        return clientCost;
    }

    public double CalculateClientCost(string surname)
    {
        double clientCost = 0;

        var client = ClientsList.Find(t => surname == t.Surname);

        foreach (var tariffOfCallsPerArea in client.NumberOfCallsPerArea)
        {
            var tariff = TariffsList.Find(t => t.Area == tariffOfCallsPerArea.Key);
            if (tariff != null) clientCost += tariff.Price * tariffOfCallsPerArea.Value;
        }

        // foreach (KeyValuePair<TariffAreas, int> tariffOfCallsPerArea in client.NumberOfCallsPerArea)
        // {
        //     Tariffs tariff = TariffsList.Find(IsMatchingArea);
        //
        //     bool IsMatchingArea(Tariffs t)
        //     {
        //         return t.Area == tariffOfCallsPerArea.Key;
        //     }
        //
        //     clientCost += tariff.Price * tariffOfCallsPerArea.Value;
        // }

        return clientCost;
    }

    public double CalculateAllClientsCost()
    {
        double totalCost = 0;

        foreach (var everyClient in ClientsList)
        {
            totalCost += CalculateClientCost(everyClient);
        }

        return totalCost;
    }
}