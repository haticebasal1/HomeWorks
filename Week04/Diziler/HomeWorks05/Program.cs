Console.WriteLine("Bir dizi giriniz: ");
int number =int.Parse(Console.ReadLine()!);
int[] dizi = new int[number];
for (int i = 0; i <number; i++)
{
    Console.Write($"Dizinin {i + 1}.elemanı girin:");
    dizi[i] =int.Parse(Console.ReadLine()!);
}
Console.WriteLine("Girilen dizi: ");
foreach (int eleman  in dizi)
{
    Console.WriteLine(eleman+" ");
}

