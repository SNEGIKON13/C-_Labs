using LABA9_SHARPI.Interfaces;

namespace LABA9_SHARPI.Printers;

using PrintImplementation;

public class SublimationPrinter : PrinterBase, ISort
{
    public SublimationPrinter(IPrintImplementation printImplementation) : base(printImplementation) { }

    public override void GetInfo()
    {
        Console.WriteLine($"Сублимационный Принтер: Модель={Model}, Формат={PrintFormat}");
    }

    public void Sort()
    {
        Console.WriteLine("Сортировка...");
    }
}