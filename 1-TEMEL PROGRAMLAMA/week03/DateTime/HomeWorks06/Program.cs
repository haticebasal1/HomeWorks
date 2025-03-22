internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Bir tarih giriniz:");
        int year = int.Parse(Console.ReadLine()!);
        if (DateTime.IsLeapYear(year))
            Console.WriteLine("Aryık bil yıldır.");

        else
        {
            ;
        }

        Console.WriteLine("Artık yıl değildir.");
    }
}