namespace HomeWorks18;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("İsminizi giriniz:");
        string name=Console.ReadLine()!;
        Console.WriteLine("Soyadınızı giriniz:");
        string surname=Console.ReadLine()!;
        string tamİsim=Getir(name,surname);
        Console.WriteLine("Tam isim :" +tamİsim);
    }
    static string Getir(string name,string surname)
    {
     return $"{name} {surname}";
    }
}
