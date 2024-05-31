namespace LABA9_SHARPI.Builder;

using Printers;

public class LaserPrinterBuilder : PrinterBuilder
{
    public override PrinterBase Build()
    {
        var printer = new LaserPrinter(printImplementation)
        {
            Model = model,
            PrintFormat = printFormat
        };
        return printer;
    }
}