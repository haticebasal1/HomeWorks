﻿namespace HomeWorks04;

class Program
{
    static void Main(string[] args)
    {
        int vize,final,ort;
        Console.Write("Vize notunu giriniz: ");
        vize=int.Parse(Console.ReadLine()!);
        Console.Write("Final notunu giriniz: ");
        final =int.Parse(Console.ReadLine()!);
        ort=Convert.ToInt32(vize *0.4 + final*0.6);
        Console.WriteLine("Ortalamanız={0}",ort);
        if (ort<50 || final<50)
        {
            Console.WriteLine("Kaldınız");
        }
        else
        {
            Console.WriteLine("Geçtiniz.");
        }
    }
}
