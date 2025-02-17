Console.WriteLine("Bir harf giriniz:");
char harf= char.Parse(Console.ReadLine()!);
string message=(harf=='a')?"Sesli harftir.":(harf=='e')?"Sesli harftir.":(harf=='u')?"Sesli harftir.":(harf=='ü')?"Sesli harftir.":(harf=='ı')?"Sesli harftir.":(harf=='i')?"Sesli harftir.":(harf=='o')?"Sesli harftir.":(harf=='ö')?"Sesli harftir.":"Sessiz harftir.";
Console.WriteLine(message);
