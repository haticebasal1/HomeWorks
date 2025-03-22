Console.WriteLine("Bir cümle giriniz:");
string str = Console.ReadLine()!;
    while (str!="0")
    {
        string buyuk=str.ToUpper();
        Console.WriteLine("Büyük harfle:"+buyuk);
        break;
    }


