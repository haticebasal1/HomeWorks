Console.WriteLine("Bir sayı giriniz: ");
int num =int.Parse(Console.ReadLine()!);
Console.WriteLine(num+ " sayısının tam bölenleri:");
for (int i = 1; i <=num; i++)
{
    if (num%i==0)
    {
        Console.WriteLine(i+"");
    }
}
