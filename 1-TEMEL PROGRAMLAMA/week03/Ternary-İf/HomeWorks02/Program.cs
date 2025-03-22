Console.Write("1.sayıyı giriniz:");
int number = int.Parse(Console.ReadLine()!);
Console.Write("2.sayıyı giriniz:");
int number2 = int.Parse(Console.ReadLine()!);
Console.Write("3.sayıyı giriniz:");
int number3 = int.Parse(Console.ReadLine()!);

string message=number>number2&&number>number3 ?number2 >= number3 ?$"Sıralama: {number}, {number2}, {number3}":$"Sıralama: {number}, {number2}, {number3}":     number2 >= number && number2 >= number3 ?number >= number3?$"Sıralama: {number2}, {number}, {number3}": $"Sıralama: {number2}, {number3}, {number}":  number >= number2 ? $"Sıralama: {number3}, {number}, {number2}":$"Sıralama: {number3}, {number2}, {number}";
Console.WriteLine(message);




