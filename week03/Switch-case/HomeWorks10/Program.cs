Console.WriteLine("Bir karakter giriniz: ");
char karakter=char.Parse(Console.ReadLine()!);

string message;
switch (karakter)
{
    case '+':
    message= "Toplama";
    break;
    case '-':
    message= "Çıkarma";
    break;
    case '*':
    message= "Çarpma";
    break;
    case '/':
    message= "Bölme";
    break;
    case '%':
    message= "Mod Alma";
    break;

    default:
    message="Geçersiz karakter!!";
    break;
}
Console.WriteLine(message);
