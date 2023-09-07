//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine ("Введите три числа");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());
int Maxnumber = num1;

if (num2 > Maxnumber )
{
    Maxnumber = num2;
}
if (num3 > Maxnumber )
{
    Maxnumber = num3;
}

Console.WriteLine ("Максимальное чило " + Maxnumber);
        