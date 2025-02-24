namespace HomeWorks08;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Santigrat cinsinden sıcaklığı girin:");
        string SantigratStr=Console.ReadLine()!;
        int Santigrat=Convert.ToInt32(SantigratStr);
        float fahrenheit = ((9f * Santigrat)/5f)+32;
        Console.WriteLine("Fahrenheit cinsinden sıcaklık: "+fahrenheit);
    }
}
