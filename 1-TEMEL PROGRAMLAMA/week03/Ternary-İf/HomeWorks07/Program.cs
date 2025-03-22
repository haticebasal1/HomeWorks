Console.WriteLine("1.sayıyı giriniz:");
int number1=int.Parse(Console.ReadLine()!);
Console.WriteLine("2.sayıyı giriniz:");
int number2=int.Parse(Console.ReadLine()!);
Console.WriteLine("3.sayıyı giriniz:");
int number3=int.Parse(Console.ReadLine()!);

int enbuyuk=(number2>number1)?number2 :number1;
enbuyuk= (number3 > enbuyuk)?number3 :enbuyuk;
Console.WriteLine("Girilen 3 sayıdan en büyüğü ="+enbuyuk);