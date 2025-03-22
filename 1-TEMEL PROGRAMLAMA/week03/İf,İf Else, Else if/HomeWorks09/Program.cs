Console.WriteLine("1.sayıyı giriniz: ");
int num1=int.Parse(Console.ReadLine()!);
Console.WriteLine("2.sayıyı giriniz: ");
int num2=int.Parse(Console.ReadLine()!);

Console.WriteLine("\n1.Toplama\n2.Çıkarma\n3.Çarpma\n4.Bölme");
Console.Write("\nİşleminizi seçiniz:");
int islem = int.Parse(Console.ReadLine()!);

if (islem== 1)
{
    Console.WriteLine("İşlemin sonucu= " + (num1+num2));
}
else if (islem==2)
{
    Console.WriteLine("İşlemin sonucu= " + (num1-num2));
}
else if (islem==3)
{
    Console.WriteLine("İşlemin sonucu= " + (num1*num2));
}
else if (islem==4)
{
    Console.WriteLine("İşlemin sonucu= " + (num1/num2));
}
else
{
    Console.WriteLine("Yanlış seçim yaptınız!!");
}
