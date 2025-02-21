Console.WriteLine("Bir sayı giriniz:");
int b =int.Parse(Console.ReadLine()!);
Console.WriteLine("Sayıların küpü:");
for (int i = 1; i <=b; i++)
{
  int kare=i*i;
  Console.WriteLine($"{i}^2={kare}");  
}