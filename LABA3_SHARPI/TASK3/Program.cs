using TASK3;

while (true)
{
    bool restart;
    bool invalidInput = false;
    int day, month, year;
    Console.WriteLine("В отдельном файле описать класс DateService." +
                      "\nКласс должен предоставлять следующие методы:" +
                      "\nОпределять день недели произвольной даты, передаваемой методу в качестве" +
                      "\nстрокового параметра (например GetDay(string date)" +
                      "\nОпределять, сколько дней пройдет между текущей датой и датой," +
                      "\nпередаваемой методу в качестве числовых параметров: день, месяц, год" +
                      "\n(например GetDaysSpan(int day, int month, int year);");
    do
    {
        restart = false;
        Console.WriteLine("\n1. метод GetDay");
        Console.WriteLine("2. метод GetDaysSpan");
        Console.WriteLine("\nВыберите метод:");
        string strMenu = Console.ReadLine();
        if (long.TryParse(strMenu, out long menuChoose))
        {
            switch (menuChoose)
            {
                case 1:
                    string date;
                    do
                    {
                        Console.WriteLine("Введите дату:");
                        date = Console.ReadLine();
                    } while (DataService.GetDay(date) == "Z");

                    Console.WriteLine($"День недели {DataService.GetDay(date)}");
                    break;
                case 2:
                    do
                    {
                        invalidInput = false;
                        Console.WriteLine("\nВведите день: ");
                        string strD = Console.ReadLine();
                        if (!int.TryParse(strD, out day) ||
                            !DataService.isValidDay(day))
                        {
                            Console.WriteLine("\nНеправильный ввод! Повторите попытку!");
                            invalidInput = true;
                        }
                    } while (invalidInput);

                    do
                    {
                        invalidInput = false;
                        Console.WriteLine("\nВведите месяц: ");
                        string strM = Console.ReadLine();
                        if (!int.TryParse(strM, out month) ||
                            !DataService.isValidMonth(day, month))
                        {
                            Console.WriteLine("\nНеправильный ввод! Повторите попытку!");
                            invalidInput = true;
                        }
                    } while (invalidInput);

                    do
                    {
                        invalidInput = false;
                        Console.WriteLine("\nВведите год: ");
                        string strY = Console.ReadLine();
                        if (!int.TryParse(strY, out year) ||
                            !DataService.isValidYear(day, month, year))
                        {
                            Console.WriteLine("\nНеправильный ввод! Повторите попытку!");
                            invalidInput = true;
                        }
                    } while (invalidInput);

                    if (DataService.GetDaysSpan(day, month, year) == -1)
                    {
                        Console.WriteLine("Недопустимая дата");
                    }
                    else
                    {
                        Console.WriteLine("\nДней пройдет между текущей датой и датой: ");
                        Console.WriteLine(DataService.GetDaysSpan(day, month, year));
                    }

                    break;
                default:
                    restart = true;
                    Console.WriteLine("\nНеправильный ввод! Повторите попытку!");
                    break;
            }
        }
        else
        {
            restart = true;
            Console.WriteLine("Неправильный ввод!");
        }
    } while (restart);

    restart = true;
    while (restart)
    {
        Console.WriteLine("\n1. Продолжить");
        Console.WriteLine("2. Закончить");
        string strMenu = Console.ReadLine();
        if (long.TryParse(strMenu, out long menuChoose))
        {
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