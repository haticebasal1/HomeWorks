Console.WriteLine("Bir not giriniz:");
int note = int.Parse(Console.ReadLine()!);

string message=(note<=35)?"'F'Kaldınız.": (note<=45)?"'D'Geçtiniz.":(note<=55)?"'C'Geçtiniz.":(note<=65)?"'B'Geçtiniz.":(note<=75)?"'A'Geçtiniz.":"Geçersiz not!!";
Console.WriteLine(message);
