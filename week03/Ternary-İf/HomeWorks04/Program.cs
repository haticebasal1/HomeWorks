Console.WriteLine("Bir yıl giriniz:");
int year = int.Parse(Console.ReadLine()!);

string message = DateTime.IsLeapYear(year)?$"{year} artık bir yıldır.":$"{year} artık bir yıl değildir.";
Console.WriteLine(message);

