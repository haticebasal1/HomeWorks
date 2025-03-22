System.Console.WriteLine("Bir tarih giriniz:");
DateTime week=Convert.ToDateTime(Console.ReadLine());
DateTime week2= week.AddDays(+5);
System.Console.WriteLine(week2);

