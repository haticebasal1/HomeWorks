int toplam=0;
int sayi;
do
{
    Console.WriteLine("Pozitif sayi giriniz.");
 sayi=int.Parse(Console.ReadLine()!);
 if (sayi>0)
 {
    toplam+= sayi;
 }
 else if (sayi<0)
 {
    Console.WriteLine("Sadece pozitif sayı girin.");
 }
} while (sayi !=0);
Console.WriteLine("Girilen sayıların toplamı : "+toplam);
