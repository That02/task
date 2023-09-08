//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Ввидите трехзначное число ");
int number = int.Parse(Console.ReadLine());
int secondDigit = (number / 10) % 10;

Console.WriteLine($" Показывает вторую цифру {secondDigit }");