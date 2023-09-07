//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа
Console.WriteLine("Ввидите число");
int N = int.Parse(Console.ReadLine());

for (int i = 0; i < N; i+=2)
{

    if (i %2 == 0 )
    {
        Console.Write(i);

    }

}
