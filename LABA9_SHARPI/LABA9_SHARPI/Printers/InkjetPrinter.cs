namespace LABA9_SHARPI.Printers;

using Interfaces;
using PrintImplementation;

public class InkjetPrinter : PrinterBase, IPrintFromRoll, IWebInterface
{
    public InkjetPrinter(IPrintImplementation printImplementation) : base(printImplementation) { }

    public override void GetInfo()
    {
        Console.WriteLine($"Струйный Принтер: Модель={Model}, Формат={PrintFormat}");
    }

    public void PrintFromRoll()
    {
        Console.WriteLine("Печать с рулона...");
    }

    public void WebInterface()
    {
        Console.WriteLine("Использование веб-интерфейса...");
    }
}