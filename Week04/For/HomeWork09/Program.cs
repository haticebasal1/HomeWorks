Console.WriteLine("Bir sayı giriniz:");
int b=int.Parse(Console.ReadLine()!);

int a=0;
if (b<2)
{
    Console.WriteLine($"{b} asal değildir.");
}
    else
    {
        for (int i = 2; i <=b; i++)
        {
            if (b%i==0)
            {
                a++;
                break;
            }
        }
        if (a==0)
        {
         Console.WriteLine($"{b} bir asal sayıdır!" );   
        }
        else
        {
            Console.WriteLine($"{b} asal değildir.");
        }
    }
   

