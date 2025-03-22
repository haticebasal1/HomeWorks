Console.WriteLine("1-4 arası bir sayı giriniz:");
int season =int.Parse(Console.ReadLine()!);

string message ;
switch (season)
{
    case 1 :
    message="İlkbahar";
    break;
    case 2 :
    message="Yaz";
    break;
    case 3 :
    message="Sonbahar";
    break;
    case 4 :
    message="Kış";
    break;
    default:
    message="Böyle bir sayı yok.";
    break;
}
Console.WriteLine(message);
