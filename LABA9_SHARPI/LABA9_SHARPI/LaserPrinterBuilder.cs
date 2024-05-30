namespace LABA9_SHARPI;

public class LaserPrinterBuilder : PrinterBuilder
{
    public override PrinterBase Build()
    {
        return new LaserPrinter { Model = model, PrintFormat = printFormat };
    }
}