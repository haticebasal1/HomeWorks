namespace HomeWorks17;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Sayıları giriniz:");
        string number= Console.ReadLine()!;
        List<int> sayılar =number.Split(',').Select(int.Parse).ToList();
        int adet=kac(sayılar,12);
        Console.WriteLine($"12 sayısı listede {adet} kez geçiyor.");
    }
static int kac(List<int> liste,int arananSayı)
{
    return liste.Count(sayı=> sayı== arananSayı);
}
}
