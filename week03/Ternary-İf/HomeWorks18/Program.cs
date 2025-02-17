Console.WriteLine("0-6 arasında sayı giriniz:");
int a = int.Parse(Console.ReadLine()!);

string message=(a==0)? "Nokta":(a==1)?"Çizgi":(a==2)?"Açı":(a==3)?"Üçgen":(a==4)?"Kare":(a==5)? "Beşgen":(a==6)?"Altıgen": "Geçersiz sayı!!";
Console.WriteLine(message);