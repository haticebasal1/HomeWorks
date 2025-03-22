Console.WriteLine("Bir not giriniz:");
int note = int.Parse(Console.ReadLine()!);

string message;
switch (note)
{
    case <=35:
    message="'F'Kaldınız.";
    break;
    case <=45:
    message="'D'Geçtiniz.";
    break;
    case <=55:
    message="'C'Geçtiniz.";
    break;
    case <=65:
    message="'B'Geçtiniz.";
    break;
    case <=75:
    message="'A'Geçtiniz.";
    break;
    default:
    message="Geçersiz not!!";
    break;
}
Console.WriteLine(message);
