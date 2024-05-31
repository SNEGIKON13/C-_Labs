namespace LABA9_SHARPI.PrintImplementation;

public class InkjetPrint : IPrintImplementation
{
    public void Print()
    {
        Console.WriteLine("Струйная печать...");
    }
}