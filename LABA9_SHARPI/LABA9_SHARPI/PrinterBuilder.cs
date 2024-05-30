namespace LABA9_SHARPI;

public abstract class PrinterBuilder
{
    protected string model;
    protected string printFormat;

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

    public abstract PrinterBase Build();
}