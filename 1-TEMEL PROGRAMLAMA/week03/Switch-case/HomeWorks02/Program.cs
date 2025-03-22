Console.WriteLine("1-12 sayı arasında sayı giriniz:");
int month=int.Parse(Console.ReadLine()!);

string message;
switch (month)
{
    case 1:
    message= "Ocak";
    break;
    case 2:
    message= "Şubat";
    break;
    case 3:
    message= "Mart";
    break;
    case 4:
    message= "Nisan";
    break;
    case 5:
    message= "Mayıs";
    break;
    case 6:
    message= "Haziran";
    break;
    case 7:
    message= "Temmuz";
    break;
    case 8:
    message= "Ağustos";
    break;
    case 9:
    message= "Eylül";
    break;
    case 10:
    message= "Ekim";
    break;
    case 11:
    message= "Kasım";
    break;
    case 12:
    message= "Aralık";
    break;
    default:
    message = "Böyle bir ay yok.";
    break;
}
Console.WriteLine(message);