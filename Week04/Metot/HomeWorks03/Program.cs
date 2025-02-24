namespace HomeWorks03;

class Program
{
    static string Ters(string kelime)
    {
        string tersKelime=string.Empty;
        for (int i = kelime.Length-1; i >= 0; i--)
        {
            tersKelime +=kelime[i];
        }
        return tersKelime;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Bir kelime giriniz:");
        string kelime=Console.ReadLine()!;

        string tersKelime =Ters(kelime);
        Console.WriteLine("Ters Çevrilmiş Kelime: "+tersKelime);
    }
}
