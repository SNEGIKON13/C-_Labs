namespace LABA9_SHARPI.Builder;

using Printers;
using PrintImplementation;

public abstract class PrinterBuilder
{
    protected string model;
    protected string printFormat;
    protected IPrintImplementation printImplementation;

    public PrinterBuilder SetModel(string model)
    {
        this.model = model;
        return this;
    }

    public PrinterBuilder SetPrintFormat(string format)
    {
        this.printFormat = format;
        return this;
    }

    public PrinterBuilder SetPrintImplementation(IPrintImplementation printImplementation)
    {
        this.printImplementation = printImplementation;
        return this;
    }

    public abstract PrinterBase Build();
}