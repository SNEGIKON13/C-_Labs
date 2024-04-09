using TASK2.services;

while (true)
{
bool invalidInput = false;
double z;
Console.WriteLine("Валиуллин Константин Алексеевич, 353504, Вариант 5" +
                  "\n\nДобавить в проект папку Services. В созданной папке описать" +
                  "\nкласс (с произвольным именем). В созданном классе описать метод," +
                  "\nвычисляющий значение функции в соответствии с индивидуальным" +
                  "\nвариантом. Метод должен вывести в консоль результат выполнения и номер" +
                  "\nветки, по которой производилось вычисление." +
                  "\n\ny = ln(x + 0,5) + (e^x - e^-x),\nx = -z/3, если z < -1,\nx = |z|, если z >= 1");
do {
    Console.WriteLine("\nВведите z: ");
    string strZ = Console.ReadLine();
    if (!double.TryParse(strZ, out z))
    {
        Console.WriteLine("Неправильный ввод!");
        invalidInput = true;
    }
} while (invalidInput);
Console.WriteLine($"\nЗначение выражения равно {ClassT2.FindY(z)}," +
                  $" а вычисление происходило по методу {ClassT2.FindMethod(z)} ");

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
