Console.Write ("Bir karakter giriniz:  ");
char harf =Convert.ToChar(Console.ReadLine()!);
string sesliHarfler="aeıioöuüAEIİOÖUÜ";
string message=sesliHarfler.Contains(harf)?$"Girdiğiniz harf sesli bir harftir ." : $"Girdiğiniz harf sesli bir harf değildir .";
Console.WriteLine(message);

