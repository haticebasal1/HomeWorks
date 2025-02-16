Console.WriteLine("1-5 arasında sayı giriniz:");
int money = int.Parse(Console.ReadLine()!);

string message;
switch (money)
{
   case 1:
   message="1 KR";
   break;
   case 2:
   message="5 KR";
   break;
   case 3:
   message="10 KR";
   break;
   case 4:
   message="25 KR";
   break;
   case 5:
   message="50 KR";
   break;
   default:
   message="Geçersiz sayı!!";
   break;
}
Console.WriteLine(message);
