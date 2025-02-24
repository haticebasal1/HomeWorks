namespace HomeWorks05;

class Program
{
    static void Main(string[] args)
    {
       Console.Write("Kaç kelime gireceksiniz:");
       int n=int.Parse(Console.ReadLine()!);
       string [] metinDizisi =new string [n];
       for (int i = 0; i < n; i++)
       {
        Console.Write($"{i+1}.kelimeyi girin.");
        metinDizisi [i] =Console.ReadLine()!;
       }
       for (int i = 0; i <metinDizisi.Length; i++)
       {
        metinDizisi[i]= metinDizisi[i].ToUpper();
       }
       Console.WriteLine("\nBüyük harfli metinler:");
       foreach (string metin in metinDizisi)
       {
        Console.WriteLine(metin);
       }
    }
}
