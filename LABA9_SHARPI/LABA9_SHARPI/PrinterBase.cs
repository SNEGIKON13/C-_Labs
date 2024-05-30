namespace LABA9_SHARPI;

public abstract class PrinterBase
{
    public string Model { get; set; }
    public string PrintFormat { get; set; }

    public abstract void GetInfo();
    public abstract void Print();
}