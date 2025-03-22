System.Console.WriteLine("Bir tarih giriniz:");
DateTime week=Convert.ToDateTime(Console.ReadLine());
System.Console.WriteLine("İkinci tarihi giriniz:");
DateTime week2=Convert.ToDateTime(Console.ReadLine());
TimeSpan sonuc = week2.Subtract(week);
System.Console.WriteLine(sonuc);


