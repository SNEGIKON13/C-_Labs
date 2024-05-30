namespace LABA9_SHARPI;

public class SublimationPrinterBuilder : PrinterBuilder
{
    public override PrinterBase Build()
    {
        return new SublimationPrinter { Model = model, PrintFormat = printFormat };
    }
}