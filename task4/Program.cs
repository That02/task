//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа
Console.WriteLine("Ввидите число");
int N = int.Parse(Console.ReadLine());

for (int i = 0; i < N; i++)
{

    if (N %2 == 0 )
    {
        Console.WriteLine(i);

    }

}
