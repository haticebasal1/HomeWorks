Console.WriteLine("1.sayıyı giriniz: ");
int num1=int.Parse(Console.ReadLine()!);
Console.WriteLine("2.sayıyı giriniz: ");
int num2=int.Parse(Console.ReadLine()!);

Console.WriteLine("\n1.Toplama\n2.Çıkarma\n3.Çarpma\n4.Bölme");
Console.Write("\nİşleminizi seçiniz:");
int islem = int.Parse(Console.ReadLine()!);
string message = islem== 1?"İşlemin sonucu= " + (num1+num2):islem==2?"İşlemin sonucu= " + (num1-num2):islem==3?"İşlemin sonucu= " + (num1*num2):islem==4?"İşlemin sonucu= " + (num1/num2):"Yanlış seçim yaptınız!!";
Console.WriteLine(message);
