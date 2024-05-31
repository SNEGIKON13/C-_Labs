namespace LABA9_SHARPI.Printers;

using PrintImplementation;

public abstract class PrinterBase
{
    protected IPrintImplementation printImplementation;

    public string Model { get; set; }
    public string PrintFormat { get; set; }

    public PrinterBase(IPrintImplementation printImplementation)
    {
        this.printImplementation = printImplementation;
    }

    public abstract void GetInfo();
    public void Print()
    {
        printImplementation.Print();
    }
}