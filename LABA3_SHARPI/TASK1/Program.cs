using TASK1;

while (true)
{
bool invalidInput = false;
double x, y;
Console.WriteLine("Валиуллин Константин Алексеевич, 353504, Вариант 1" +
                  "\n\nРазработать метод min(a,b) для нахождения минимального из двух чисел.\n" +
                  "Вычислить с помощью него значение выражения по следующей формуле:\n" +
                  "\n\nz = min(x, 2y + x ) - min(7x + 2y, y).");
do
{
    Console.WriteLine("\nВведите x: ");
    string strX = Console.ReadLine();
    if (!double.TryParse(strX, out x))
    {
        Console.WriteLine("Неправильный ввод!");
        invalidInput = true;
    }
} while (invalidInput);
do
{
    Console.WriteLine("Введите y: ");
    string strY = Console.ReadLine();
    if (!double.TryParse(strY, out y))
    {
        Console.WriteLine("Неправильный ввод!");
        invalidInput = true;
    }
} while (invalidInput);
double z = ClassT1.FindZ(x, y);
Console.WriteLine($"Значение выражения равно {z} ");

bool restart = true;
while (restart)
{
    Console.WriteLine("1. Продолжить");
    Console.WriteLine("2. Закончить");
    string strMenu = Console.ReadLine();
    if (long.TryParse(strMenu, out long menuChoose)) {
        switch (menuChoose)
        {
            case 1:
                Console.Clear();
                restart = false;
                break;
            case 2:
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Неправильный ввод!");
                break;
        }
    }
    else
    {
        Console.WriteLine("Неправильный ввод!");
    }
}
}