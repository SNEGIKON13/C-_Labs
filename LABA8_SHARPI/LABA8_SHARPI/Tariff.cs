namespace LABA8_SHARPI;

public class Tariff
{
    private IPrice _ip;
    public string Name { get; private set; }

    public Tariff(string name, IPrice ip)
    {
        Name = name;
        _ip = ip;
    }

    public double GetPrice()
    {
        return _ip.GetPrice();
    }
}