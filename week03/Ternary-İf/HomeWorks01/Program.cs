Console.Write("Bir sayı giriniz:");
int number = int.Parse(Console.ReadLine()!);

string message=number >0 ? $"{number} pozitif bir sayıdır.":$"{number} negatif bir sayıdır.";
Console.WriteLine(message);
