Console.Write ("Bir karakter giriniz:  ");
char harf =Convert.ToChar(Console.ReadLine()!);
string sesliHarfler= "aeıioöuüAEIİOÖUÜ";
if (sesliHarfler.Contains(harf))
{
    Console.WriteLine($"Girdiğiniz harf sesli bir harftir .",harf);
}
else
{
    Console.WriteLine($"Girdiğiniz harf sesli bir harf değildir .",harf);
}
Console.WriteLine();