Console.WriteLine("Bir sayı giriniz:");
double a=double.Parse(Console.ReadLine()!);
Console.WriteLine("Sayıların Toplamı:");
int toplam=0;
for (int i = 2; i <= a; i+=2)
{
  toplam+=i;
}
Console.Write("Çift Sayıların Toplamı:"+toplam);