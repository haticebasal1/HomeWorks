Console.WriteLine("1-5 arasında sayı giriniz: ");
int number = int.Parse(Console.ReadLine()!);

string message;
switch (number)
{
    case 1 :
    message="1:Birinci";
    break;
    case 2 :
    message="2:İkinci";
    break;
    case 3 :
    message="3:Üçüncü";
    break;
    case 4 :
    message="4:Dördüncü";
    break;
    case 5 :
    message="5:Beşinci";
    break;
    default:
    message="Geçersiz kod";
    break;

}
Console.WriteLine(message);

