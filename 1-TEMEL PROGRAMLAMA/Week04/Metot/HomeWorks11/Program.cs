namespace HomeWorks11;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir kelime giriniz");
        string kelime=Console.ReadLine()!;
        string sesli="aeıioöuü";
        int sayac=0;
        for (int i = 0; i < kelime.Length; i++)
        {
            if (sesli.Contains(kelime[i]))
            {
                sayac++;
            }
        }
        Console.WriteLine(kelime);
        Console.WriteLine("Yukarıdaki ifadede toplam {0} tane sesli harf vardır.",sayac);
    }
}
