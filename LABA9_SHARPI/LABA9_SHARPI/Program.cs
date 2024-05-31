using LABA9_SHARPI.Builder;
using LABA9_SHARPI.Printers;
using LABA9_SHARPI.Interfaces;

List<PrinterBase> printers = new List<PrinterBase>();

printers.AddRange(new PrinterBase[] {
    Director.CreateLaserPrinter("LaserJet 9000", "A4"),
    Director.CreateInkjetPrinter("Inkjet 3000", "A3"),
    Director.CreateSublimationPrinter("SublimationPro X", "A2")
});

foreach (PrinterBase printer in printers)
{
    printer.GetInfo();
    printer.Print();

    if (printer is IPrintFromSheet printFromSheetPrinter)
    {
        printFromSheetPrinter.PrintFromSheet();
    }

    if (printer is ISort sortPrinter)
    {
        sortPrinter.Sort();
    }

    if (printer is IPrintFromRoll printFromRollPrinter)
    {
        printFromRollPrinter.PrintFromRoll();
    }

    if (printer is IWebInterface webInterfacePrinter)
    {
        webInterfacePrinter.WebInterface();
    }

    Console.WriteLine();
}