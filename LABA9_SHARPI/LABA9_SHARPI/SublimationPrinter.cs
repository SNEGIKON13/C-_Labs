namespace LABA9_SHARPI;

public class SublimationPrinter : PrinterBase, ISort
{
    public override void GetInfo()
    {
        Console.WriteLine($"Сублимационный Принтер: Модель={Model}, Формат={PrintFormat}");
    }

    public override void Print()
    {
        Console.WriteLine("Сублимационная печать...");
    }

    public void Sort()
    {
        Console.WriteLine("Сортировка...");
    }
}