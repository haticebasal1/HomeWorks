namespace HomeWorks19;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Başlangıç sayısını giriniz:");
        int baslangıç =int.Parse(Console.ReadLine()!);
        Console.WriteLine("Bitiş sayısını giriniz:");
        int bitis =int.Parse(Console.ReadLine()!);
        Console.WriteLine($"{baslangıç} ile {bitis} arasındaki asal sayılar:");
        AsalBul(baslangıç,bitis);
    }
    static void AsalBul (int baslangıç, int bitis)
    {
        for (int i = baslangıç; i <= bitis; i++)
        {
            if (AsalMi(i))
            {
                Console.WriteLine(i+"");
            }
        }
    }
    static bool AsalMi(int sayi)
    {
        if (sayi<2)
        {
            return false;
        }
        for (int i = 2; i*i <= sayi; i++)
        {
            if (sayi % i==0)
            {
                return false;
            }
           
        }
         return true;
    }
}
