Console.WriteLine("1-7 arasında bir sayı giriniz:");
int day=int.Parse(Console.ReadLine()!);

string message;
switch (day)
{
    case 1 :
    message="Pazartesi";
    break;
    case 2 :
    message="Salı";
    break;
    case 3 :
    message="Çarşamba";
    break;
    case 4 :
    message="Perşembe";
    break;
    case 5 :
    message="Cuma";
    break;
    case 6 :
    message="Cumartesi";
    break;
    case 7 :
    message="Pazar";
    break;
    default:
    message="Böyle bir gün yok.";
    break;
}
Console.WriteLine(message);