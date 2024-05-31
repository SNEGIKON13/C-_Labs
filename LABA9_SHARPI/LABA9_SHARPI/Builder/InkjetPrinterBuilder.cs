namespace LABA9_SHARPI.Builder;

using Printers;

public class InkjetPrinterBuilder : PrinterBuilder
{
    public override PrinterBase Build()
    {
        var printer = new InkjetPrinter(printImplementation)
        {
            Model = model,
            PrintFormat = printFormat
        };
        return printer;
    }
}