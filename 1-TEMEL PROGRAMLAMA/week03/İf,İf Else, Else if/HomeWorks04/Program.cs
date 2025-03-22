Console.WriteLine("Bir yıl giriniz:");
int year = int.Parse(Console.ReadLine()!);
if (DateTime.IsLeapYear(year))
{
    Console.WriteLine($"{year} artık bir yıldır.");
}
else
{
    Console.WriteLine($"{year} artık bir yıl değildir.");
}
Console.WriteLine();
