Console.WriteLine("Bir sayı giriniz:");
byte number1=byte.Parse(Console.ReadLine()!);
string message=number1 % 3==0 && number1%5==0? "Sayınız:  " + number1 + " Hem 3 hem de 5'e tam bölünür.": "Sayınız 3'e ve 5'e tam bölünmez.";
Console.WriteLine(message);
