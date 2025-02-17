Console.WriteLine("1-5 arasında sayı giriniz: ");
int number = int.Parse(Console.ReadLine()!);

string message=(number==1)?"1:Birinci":(number==2)?"2:İkinci":(number==3)?"3:Üçüncü":(number==4)?"4:Dördüncü":(number==5)?"5:Beşinci":"Geçersiz kod";
Console.WriteLine(message);
