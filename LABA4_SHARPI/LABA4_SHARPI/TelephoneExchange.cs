namespace LABA4_SHARPI;

public class TelephoneExchange
{
    private static TelephoneExchange? _instance;
    private readonly Tariff _tariff;

    private string _address;

    public string Address
    {
        get => _address;
        set => _address = value ?? throw new ArgumentNullException(nameof(value));
    }

    private uint _numberOfSubscribers;

    public uint NumberOfSubscribers
    {
        get => _numberOfSubscribers;
        set => _numberOfSubscribers = value;
    }

    private TelephoneExchange(string address, uint numberOfSubscribers, double price)
    {
        _numberOfSubscribers = numberOfSubscribers;
        _address = address;
        _tariff = new Tariff(price);
    }

    public override string ToString()
    {
        return _address;
    }

    public double EstimateAbonentsFee()
    {
        return _numberOfSubscribers * _tariff.PriceOfTheTariff;
    }

    public double GetPriceOfTheTariff()
    {
        return _tariff.PriceOfTheTariff;
    }

    public void PriceUp()
    {
        _tariff.PriceUp();
    }

    public void PriceDown()
    {
        _tariff.PriceDown();
    }

    public void PriceUp(double increase)
    {
        _tariff.PriceUp(increase);
    }

    public void PriceDown(double decrease)
    {
        _tariff.PriceDown(decrease);
    }

    public static TelephoneExchange Instance(string address = " ", uint numberOfSubscribers = 0, double price = 0)
    {
        {
            return _instance ??= new TelephoneExchange(address, numberOfSubscribers, price);
        }
    }
}