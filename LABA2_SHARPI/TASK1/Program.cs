while (true)
{
    Console.WriteLine("Введите число:");
    string str1 = Console.ReadLine();
    char x = str1[^1];
    if (long.TryParse(x.ToString(), out long number)) {
        if (number % 2 == 1)
        {
            Console.WriteLine($"Число {str1} нечетное");
        }
        else
        {
            Console.WriteLine($"Число {str1} четное");
        }
        bool restart = true;
        while (restart)
        {
            Console.WriteLine("1. Продолжить");
            Console.WriteLine("2. Закончить");
            str1 = Console.ReadLine();
            if (long.TryParse(str1, out number)) {
                switch (number)
                {
                    case 1:
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
    else
    {
        Console.WriteLine("Неправильный ввод!");
    }
}