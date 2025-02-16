Console.WriteLine("Bir harf giriniz:");
char harf= char.Parse(Console.ReadLine()!);
string message;
switch (harf)
{
    case 'a':
    message="Sesli harftir.";
    break;
    case 'e':
    message="Sesli harftir.";
    break;
    case 'u':
    message="Sesli harftir.";
    break;
    case 'ü':
    message="Sesli harftir.";
    break;
    case 'ı':
    message="Sesli harftir.";
    break;
    case 'i':
    message="Sesli harftir.";
    break;
    case 'o':
    message="Sesli harftir.";
    break;
    case 'ö':
    message="Sesli harftir.";
    break;
    default:
    message="Sessiz harftir.";
    break;
}
Console.WriteLine(message);