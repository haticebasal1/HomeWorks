Console.WriteLine("1-7 arasında bir sayı giriniz:");
int day=int.Parse(Console.ReadLine()!);

string message = (day==1) ?"Pazartesi": (day== 2)?"Salı":(day==3)?"Çarşamba":(day==4)?"Perşembe":(day==5)?"Cuma":(day==6)?"Cumartesi":(day==7)?"Pazar":"Böyle bir gün yok.";
Console.WriteLine(message);