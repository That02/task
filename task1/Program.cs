// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Ввидите первое число");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Ввидите второе число");
int number2 = int.Parse(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine($"Большие число  {number1}");
    Console.WriteLine($"Меньшие  число  {number2}");
}
else if (number1 < number2)
{
    Console.WriteLine($"Большие число  {number2}");
    Console.WriteLine($"Меньшие  число  {number1}");
}
else
{
    Console.WriteLine(" Числа равны");
}