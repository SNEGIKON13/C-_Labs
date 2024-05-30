namespace LABA9_SHARPI;

public class InkjetPrinter : PrinterBase, IPrintFromRoll, IWebInterface
{
    public override void GetInfo()
    {
        Console.WriteLine($"Струйный Принтер: Модель={Model}, Формат={PrintFormat}");
    }

    public override void Print()
    {
        Console.WriteLine("Струйная печать...");
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