Console.WriteLine("1-4 arası bir sayı giriniz:");
int season =int.Parse(Console.ReadLine()!);

string message =(season==1)?"İlkbahar":(season==2)?"Yaz":(season==3)?"Sonbahar":(season==4)?"Kış":"Böyle bir sayı yok.";
Console.WriteLine(message);

