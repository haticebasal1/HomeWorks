namespace HomeWorks09;

class Program
{
    static void Main()
    {
        Console.Write("Lütfen dizinin eleman sayısını giriniz : ");

int stringLength = int.Parse(Console.ReadLine()!);
int[] numberString = new int[stringLength];
int enkucuk=int.MaxValue;

for (int i = 0; i < stringLength; i++)
{
    Console.Write("Lütfen dizinin {0}. elemanını giriniz : ", i+1);
    numberString[i] = int.Parse(Console.ReadLine()!);
if (numberString[i]<enkucuk)
{
    enkucuk=numberString[i];
} 

}
Console.WriteLine("Dizinin en küçük elemanı = " + enkucuk);
}
}
