Console.Write("1.Kenar Uzunluğunu Giriniz: ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("2.Kenar Uzunluğunu Giriniz: ");
int b = int.Parse(Console.ReadLine()!);

Console.Write("3.Kenar Uzunluğunu Giriniz: ");
int c = int.Parse(Console.ReadLine()!);

if (a + b > c && a + c > b && b + c > a)
{
    Console.WriteLine("Üçgen oluşturulabilir!");
}
else
{
    Console.WriteLine("Üçgen oluşturulamaz!");
}
