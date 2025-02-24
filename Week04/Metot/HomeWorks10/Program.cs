namespace HomeWorks10;

class Program
{
    static void Main(string[] args)
    {
         Console.Write("Lütfen dizinin eleman sayısını giriniz : ");

int stringLength = int.Parse(Console.ReadLine()!);
int[] numberString = new int[stringLength];

for (int i = 0; i < stringLength; i++)
{
    Console.Write("Lütfen dizinin {0}. elemanını giriniz : ", i+1);
    numberString[i] = int.Parse(Console.ReadLine()!);
    }
     Console.WriteLine("Dizi içindeki sayıların toplamı :" + Topla(numberString));
}

static int Topla (int[]numberString)
{
int toplam=0;
for (int i = 0; i < numberString.Length; i++)
toplam +=numberString[i];
return toplam;
{   
}
}
}
