while (true)
{
    bool invalidInput;
    double numberX, numberY;
    string strX, strY;
    do
    {
        invalidInput = false;
        Console.WriteLine("Введите точку X:");
        strX = Console.ReadLine();
        if (!double.TryParse(strX, out numberX))
        {
            Console.WriteLine("Неправильный ввод!");
            invalidInput = true;
        }
    } while (invalidInput);
    do
    {
        Console.WriteLine("Введите точку Y:");
        strY = Console.ReadLine();
        if (!double.TryParse(strY, out numberY))
        {
            Console.WriteLine("Неправильный ввод!");
            invalidInput = true;
        }
    } while (invalidInput);
    double equation = Math.Sqrt(Math.Pow(numberX, 2) + Math.Pow(numberY, 2));
    bool rightY = numberY >= 0;
    if (equation < 3 && rightY && !(numberY == 0 && (numberX >= -3 || numberX <= 3)))
    {
        Console.WriteLine("Да");
    }
    else if ((equation == 3 && rightY) || (numberY == 0 && (numberX >= -3 || numberX <= 3)))
    {
        Console.WriteLine("На границе");
    }
    else
    {
        Console.WriteLine("Нет");
    }
    bool restart = true;
    while (restart)
    {
        Console.WriteLine("1. Продолжить");
        Console.WriteLine("2. Закончить");
        strX = Console.ReadLine();
        if (long.TryParse(strX, out long menuChoose)) {
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