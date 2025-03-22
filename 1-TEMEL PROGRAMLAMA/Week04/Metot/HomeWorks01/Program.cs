namespace HomeWorks01;

class Program
{
    static int Age()
{
    Console.WriteLine("Yaşınız giriniz");
    int Age=int.Parse(Console.ReadLine()!);

    if (Age>65)
    {
        Console.WriteLine("Emeklilik yaşında");
    }
    else
    {
        Console.WriteLine("Çalışma yaşında");
    }
    int result=Age;
    return result;
}
static void Main()
{
   int kullanıcıYası = Age();
   Console.WriteLine("Girilen yaş:"+ kullanıcıYası);
}

}
