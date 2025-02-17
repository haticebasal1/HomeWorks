Console.WriteLine("1-12 sayı arasında sayı giriniz:");
int month=int.Parse(Console.ReadLine()!);

string message= (month ==1)?"Ocak":(month ==2)?"Şubat":(month ==3)?"Mart":(month ==4)? "Nisan":(month ==5)?"Mayıs":(month ==6)?"Haziran":(month ==7)?"Temmuz":(month ==8)?"Ağustos":(month ==9)?"Eylül":(month ==10)?"Ekim":(month ==11)? "Kasım":(month ==12)?"Aralık":"Böyle bir ay yok.";
Console.WriteLine(message);
