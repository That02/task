

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите номер дня недели (1 - ПН, 2 - ВТ 3 - СР, 4 - ЧТ, 5-ПТ, 6 - СБ, 7 - ВС): ");
        int dayOfWeek = int.Parse(Console.ReadLine());

        if (IsWeekend(dayOfWeek))
        {
            Console.WriteLine("Этот день является выходным.");
        }
        else
        {
            Console.WriteLine("Этот день не является выходным.");
        }
    }

    static bool IsWeekend(int dayOfWeek)
    {
        
        return dayOfWeek == 6 || dayOfWeek == 7;
    }
}