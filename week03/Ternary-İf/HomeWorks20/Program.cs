Console.WriteLine("Bir karakter giriniz: ");
char karakter=char.Parse(Console.ReadLine()!);

string message=(karakter=='+')? "Toplama":(karakter=='-')?"Çıkarma":(karakter=='*')?"Çarpma":(karakter=='/')?"Bölme":(karakter=='%')?"Mod Alma":"Geçersiz karakter!!";
Console.WriteLine(message);
