Console.WriteLine("1.sayıyı giriniz:");
int number1=int.Parse(Console.ReadLine()!);
Console.WriteLine("2.sayıyı giriniz:");
int number2=int.Parse(Console.ReadLine()!);
Console.WriteLine("3.sayıyı giriniz:");
int number3=int.Parse(Console.ReadLine()!);
 
int enbuyuk=number1;
if (number2>enbuyuk)
{
    enbuyuk=number2;
}
if (number3> enbuyuk)
{
    enbuyuk=number3;
}
Console.WriteLine("Girilen 3 sayıdan en büyüğü ="+enbuyuk);
