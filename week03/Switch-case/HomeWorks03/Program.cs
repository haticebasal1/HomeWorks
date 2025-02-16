Console.WriteLine("1.sayıyı giriniz:");
int one=int.Parse(Console.ReadLine()!);
Console.WriteLine("2.sayıyı giriniz:");
int two=int.Parse(Console.ReadLine()!);
Console.WriteLine("1)Toplama");
Console.WriteLine("2)Çıkarma");
Console.WriteLine("3)Çarpma");
Console.WriteLine("4)Bölme");
Console.WriteLine("Seçiminiz: ");
string sonuç= Console.ReadLine()!;
switch (sonuç)
{
    case "1 ":
    sonuç=$"Sonuç: "+(one+two);
    break;
    case "2" :
    sonuç=$"Sonuç: "+(one-two);
    break;
    case "3" :
    sonuç=$"Sonuç: "+(one*two);
    break;
    case "4 ":
    sonuç=$"Sonuç: "+(one/two);
    break;
    default:
    sonuç=$"Böyle bir sayı yok.";
    break;
}
Console.WriteLine(sonuç);
