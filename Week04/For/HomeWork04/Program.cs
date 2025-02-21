Console.WriteLine("Bir sayı giriniz:");
int b=int.Parse(Console.ReadLine()!);
for (int i = 1; i <=b; i++)
{
 for (int j = 1; j <= i; j++)
 {
    Console.Write("*");
 }
 Console.WriteLine();
}
