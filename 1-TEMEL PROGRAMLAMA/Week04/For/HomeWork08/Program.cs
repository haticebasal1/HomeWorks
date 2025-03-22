Console.WriteLine("Bir sayı giriniz:");
int b=int.Parse(Console.ReadLine()!);
if (b<=0)
{
    Console.WriteLine("Lütfen pozitif sayı giriniz.");
}
for (int i = b; i >= 1; i--)
{
    Console.WriteLine($"{i}^2 ={i*i}");
}
