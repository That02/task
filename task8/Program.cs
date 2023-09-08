 //Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());

        int thirdDigit = GetThirdDigit(number);

        if (thirdDigit != -1)
        {
            Console.WriteLine($"Третья цифра числа: {thirdDigit}");
        }
        else
        {
            Console.WriteLine("Третьей цифры нет.");
        }
    }

    static int GetThirdDigit(int number)
    {
        if (number > 100)
        {
            
            int thirdDigit = (number / 100) % 10;
            return thirdDigit;
        }
        else
        {
            
            return -1;
        }
    }
}
   
