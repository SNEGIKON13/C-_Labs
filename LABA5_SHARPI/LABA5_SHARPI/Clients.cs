namespace LABA5_SHARPI;

public class Clients
{
    public string Surname { get; init; }
    public Dictionary<EnumOfTariffAreas, int> NumberOfCallsPerArea { get; set; } = new();
}