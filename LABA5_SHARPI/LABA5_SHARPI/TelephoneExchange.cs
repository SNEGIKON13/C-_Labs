namespace LABA5_SHARPI;

public enum EnumOfTariffAreas
{
    Minsk,
    Vitebsk,
    Mogilev,
    Homiel,
    Brest,
    Hrodna
}

public class TelephoneExchange
{
    public List<Tariffs> TariffsList { get; set; } = new();
    public List<Clients> ClientsList { get; set; } = new();

    public double CalculateClientCost(Clients client)
    {
        double clientCost = 0;

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

    public double CalculateClientCost(String surname)
    {
        double clientCost = 0;

        Clients client = ClientsList.Find(t => surname == t.Surname);

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

public class Clients
{
    public string Surname { get; init; }
    public Dictionary<EnumOfTariffAreas, int> NumberOfCallsPerArea { get; set; } = new();
}

public class Tariffs
{
    public EnumOfTariffAreas Area { get; init; }
    public double Price { get; init; }
}