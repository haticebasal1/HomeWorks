namespace HomeWorks15;

class Program
{
    static void Main(string[] args)
    {
     Console.Write("Lütfen dizinin eleman sayısını giriniz : ");

     int stringLength = int.Parse(Console.ReadLine()!);
     int[] numberString = new int[stringLength];
     int toplam =0;

    for (int i = 0; i < stringLength; i++)
    {
    Console.Write("Lütfen dizinin {0}. elemanını giriniz : ", i+1);
    numberString[i] = int.Parse(Console.ReadLine()!);
    toplam +=numberString[i];
    }
    Console.WriteLine("Dizinin ortalaması ="+(toplam/stringLength));
}
}