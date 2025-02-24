namespace HomeWorks13;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Metin girin:");
        string metin =Console.ReadLine()!;
        int kelimesayısı= sayı1(metin);
        Console.WriteLine("Metindeki kelime sayısı: "+kelimesayısı);

    }
    static int sayı1(string metin)
    {
        int kelimesayısı=0;
        bool kelimeBaşında =true;
        for (int i = 0; i <metin.Length; i++)
        {
            if (char.IsWhiteSpace(metin[i]) || char.IsPunctuation(metin[i]))
            {
                kelimeBaşında=true;
            }
            else if (kelimeBaşında)
            {
                kelimesayısı++;
                kelimeBaşında=false;
            }
        }
        return kelimesayısı;
    }
}
