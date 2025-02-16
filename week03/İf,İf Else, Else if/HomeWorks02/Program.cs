Console.Write("1.sayıyı giriniz:");
int number = int.Parse(Console.ReadLine()!);
Console.Write("2.sayıyı giriniz:");
int number2 = int.Parse(Console.ReadLine()!);
Console.Write("3.sayıyı giriniz:");
int number3 = int.Parse(Console.ReadLine()!);

if (number>number2&&number>number3)
{
    if (number2 >= number3)
                Console.WriteLine($"Sıralama: {number}, {number2}, {number3}");
            else
                Console.WriteLine($"Sıralama: {number}, {number3}, {number2}");
        }
        else if (number2 >= number && number2 >= number3)
        {
            if (number >= number3)
                Console.WriteLine($"Sıralama: {number2}, {number}, {number3}");
            else
                Console.WriteLine($"Sıralama: {number2}, {number3}, {number}");
        }
        else
        {
            if (number >= number2)
                Console.WriteLine($"Sıralama: {number3}, {number}, {number2}");
            else
                Console.WriteLine($"Sıralama: {number3}, {number2}, {number}");
        }
    