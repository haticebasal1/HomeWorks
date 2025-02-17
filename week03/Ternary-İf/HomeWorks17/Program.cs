Console.WriteLine("1-5 arasında sayı giriniz:");
int money = int.Parse(Console.ReadLine()!);

string message=(money==1)?"1 KR":(money==2)?"5 KR":(money==3)?"10 KR":(money==4)?"25 KR":(money==5)?"50 KR":"Geçersiz sayı!!";
Console.WriteLine(message);
