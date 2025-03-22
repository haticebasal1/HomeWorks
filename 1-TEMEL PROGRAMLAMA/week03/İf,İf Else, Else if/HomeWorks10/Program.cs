Console.Write("Asal sayı olup olmadığını kontrol edeceğimiz sayıyı giriniz: ");
int number = int.Parse(Console.ReadLine()!);
if (number <= 1)
{
    Console.WriteLine($"{number} bir asal sayı değildir!");
}
else
{
    bool isPrime = true;
    for (int i = 2; i <= Math.Sqrt(number); i++)
    {
        if (number % i == 0)
        {
            isPrime = false;
            break;
        }
    }
    Console.WriteLine("-------------");
    Console.WriteLine(isPrime == true ? $"{number} bir asal sayıdır!" : $"{number} bir asal sayı değildir!");
}