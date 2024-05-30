namespace LABA9_SHARPI;

public class InkjetPrinterBuilder : PrinterBuilder
{
    public override PrinterBase Build()
    {
        return new InkjetPrinter { Model = model, PrintFormat = printFormat };
    }
}