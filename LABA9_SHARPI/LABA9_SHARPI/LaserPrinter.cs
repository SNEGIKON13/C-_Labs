namespace LABA9_SHARPI;

public class LaserPrinter : PrinterBase, IPrintFromSheet
{
    public override void GetInfo()
    {
        Console.WriteLine($"Лазерный Принтер: Модель={Model}, Формат={PrintFormat}");
    }

    public override void Print()
    {
        Console.WriteLine("Лазерная печать...");
    }

    public void PrintFromSheet()
    {
        Console.WriteLine("Печать с листа...");
    }
}