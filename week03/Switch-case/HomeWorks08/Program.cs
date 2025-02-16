Console.WriteLine("0-6 arasında sayı giriniz:");
int a = int.Parse(Console.ReadLine()!);

string message;
switch (a)
{
    case 0 :
    message = "Nokta";
    break;
    case 1 :
    message = "Çizgi";
    break;
    case 2 :
    message = "Açı";
    break;
    case 3 :
    message = "Üçgen";
    break;
    case 4 :
    message = "Kare";
    break;
    case 5 :
    message = "Beşgen";
    break;
    case 6 :
    message = "Altıgen";
    break;
    default: 
    message = "Geçersiz sayı!!";
    break;
}
Console.WriteLine(message);

