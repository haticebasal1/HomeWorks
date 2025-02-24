namespace HomeWorks14;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1.tarihi giriniz:");
        DateTime date1=DateTime.Parse(Console.ReadLine()!);
        Console.WriteLine("2.tarihi giriniz:");
        DateTime date2=DateTime.Parse(Console.ReadLine()!);
        TimeSpan time= date1-date2;
        Console.WriteLine($"İki tarih arasındaki gün farkı:{Math.Abs(time.Days)}");
    }
}
