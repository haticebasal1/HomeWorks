Console.WriteLine("Bir sayı giriniz:");
int number=int.Parse(Console.ReadLine()!);
int toplam = 0;
for (int i = 1; i <=number; i++)
{
    toplam +=i;
}
Console.WriteLine($"1'den {number}'e kadar olan sayıların toplamı :{toplam}");