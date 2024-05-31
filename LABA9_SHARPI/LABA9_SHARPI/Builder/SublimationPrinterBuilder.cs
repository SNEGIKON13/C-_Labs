namespace LABA9_SHARPI.Builder;

using Printers;

public class SublimationPrinterBuilder : PrinterBuilder
{
    public override PrinterBase Build()
    {
        var printer = new SublimationPrinter(printImplementation)
        {
            Model = model,
            PrintFormat = printFormat
        };
        return printer;
    }
}