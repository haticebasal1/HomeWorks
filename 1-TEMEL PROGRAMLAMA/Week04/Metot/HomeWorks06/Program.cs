using System.Globalization;

namespace HomeWorks06;

class Program
{
    static void TekÇift(int sayı)
    {
       if (sayı %2 ==0)
       {
        Console.WriteLine("Sayı çiftir.");
       }
       else
       {
        Console.WriteLine("Sayı tektir.");
       }
    }
    static void Main(string[] args)
    {
    int deger;
    Console.Write("Sayı giriniz:");
    deger = int.Parse(Console.ReadLine()!);
    TekÇift(deger);
    
    }
}
