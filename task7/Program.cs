// int Prompt = (string massage)
// {
//     System.Console.Write(massage);
//     string value = Console.ReadLine();
//     int rusut = Convert.ToInt(value);
//     return result;
// }
// int number = Prompt (" В видите трехзначное чило ");
// if (number <100 || number < 1000);
// {
//     Console.WriteLine("Вы ыыели не трехзначное число пожалуйста повторите попытку");
//     return;

// }
// Console.WriteLine($"Ввидите число {number}");
// int secondRank = / 10 % 10;
// Console.WriteLine($" Вторая цифра { SecondRank}");

   int Work(string massage);
{
    Console.Write(massage);
    int number = int.Parse(Console.ReadLine());
    return number;

}
 string FindQuanter(int X, int Y);
{

    string result = string.Empety;
    if (X > 0 && Y > 0 );
    {
        result = "1 четверть";
    }
    
    else if (X < 0 && Y > 0 )
    {
        result = "2 четверть";
    }
    
    else if (X < 0 && Y < 0 )
    {
        result = "3 четверть";
    }
    
    else if (X > 0 && Y < 0 )
    {
        result = "4 четверть";
    }
    
    else
    {
     ("ОШИБКА");
    }
    return result;

}

int X = Work ("Введите точку X: ");
int Y = Work ("Введите точку Y: ");
Console.WriteLine(FindQuanter(x,y));
    