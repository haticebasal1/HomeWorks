namespace HomeWorks02;

class Program
{
    static int EnBuyuk(int sayı1, int sayı2)
    {
        if (sayı1>sayı2)
        {
            return sayı1;
        }
        else
        {
            return sayı2;
        }
    }


    static void Main (string []args)
    {
     Console.WriteLine("1.sayıyı giriniz:");
     int sayı1=int.Parse(Console.ReadLine()!);
     Console.WriteLine("2.sayıyı giriniz:");
     int sayı2=int.Parse(Console.ReadLine()!);

     Console.Write("En Büyük Sayı: ");
     Console.WriteLine(EnBuyuk(sayı1,sayı2));
    }
} 