using System.Globalization;

namespace TASK3;

public class DataService
{
    public static string GetDay(string date)
    {
        DateTime userTime;
        if (!DateTime.TryParse(date, out userTime))
        {
            Console.WriteLine("Неправильный ввод!");
            return "Z";
        }
        DayOfWeek dayOfWeek = userTime.DayOfWeek;
        switch (dayOfWeek)
        {
            case DayOfWeek.Sunday:
                return "Воскресенье";
            case DayOfWeek.Monday:
                return "Понедельник";
            case DayOfWeek.Tuesday:
                return "Вторник";
            case DayOfWeek.Wednesday:
                return "Среда";
            case DayOfWeek.Thursday:
                return "Четверг";
            case DayOfWeek.Friday:
                return "Пятница";
            case DayOfWeek.Saturday:
                return "Суббота";
            default:
                return string.Empty;
        }
    }

    public static int GetDaysSpan(int day, int month, int year)
    {
        if (!IsValidDate(day, month, year))
        {
            Console.WriteLine("Недопустимая дата");
            return -1;
        }
        DateTime currentTime = DateTime.Today;
        DateTime userTime = new DateTime(year, month, day);
        TimeSpan timeSpan = userTime - currentTime;
        int numberOfDays = timeSpan.Days;
        return numberOfDays;
    }

    static bool IsValidDate(int day, int month, int year)
    {
        if (year < 1 || month < 1 || month > 12 || day < 1 || day > 31)
            return false;
        if ((month == 4 || month == 6 || month == 9 || month == 11) && day > 30)
            return false;
        if (month == 2)
        {
            if (IsLeapYear(year))
            {
                if (day > 29)
                    return false;
            }
            else
            {
                if (day > 28)
                    return false;
            }
        }
        return true;
    }
    static bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
    }
}