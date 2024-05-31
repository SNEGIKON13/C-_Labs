namespace LABA9_SHARPI.Printers;

using Interfaces;
using PrintImplementation;

public class LaserPrinter : PrinterBase, IPrintFromSheet
{
    public LaserPrinter(IPrintImplementation printImplementation) : base(printImplementation) { }

    public override void GetInfo()
    {
        Console.WriteLine($"Лазерный Принтер: Модель={Model}, Формат={PrintFormat}");
    }

    public void PrintFromSheet()
    {
        Console.WriteLine("Печать с листа...");
    }
}