namespace LABA9_SHARPI;

public static class Director
{
    public static PrinterBase CreateLaserPrinter(string model, string format)
    {
        return new LaserPrinterBuilder()
            .SetModel(model)
            .SetPrintFormat(format)
            .Build();
    }

    public static PrinterBase CreateInkjetPrinter(string model, string format)
    {
        return new InkjetPrinterBuilder()
            .SetModel(model)
            .SetPrintFormat(format)
            .Build();
    }

    public static PrinterBase CreateSublimationPrinter(string model, string format)
    {
        return new SublimationPrinterBuilder()
            .SetModel(model)
            .SetPrintFormat(format)
            .Build();
    }
}