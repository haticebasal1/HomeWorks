Console.WriteLine("1.sayıyı giriniz:");
int a =int.Parse(Console.ReadLine()!);
Console.WriteLine("2.sayıyı giriniz:");
int b=int.Parse(Console.ReadLine()!);
int çarpım=1;
for (int i =a; i <=b; i++)
{
    çarpım *= i;
}
Console.WriteLine(çarpım);