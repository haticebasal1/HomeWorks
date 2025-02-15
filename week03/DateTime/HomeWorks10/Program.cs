System.Console.WriteLine("12 saatlik formatta bir saat giriniz:");
string inputTime =Console.ReadLine()!;
if (DateTime.TryParse(inputTime, out DateTime time))
{
    string time24 = time.ToString("HH:hh");
    Console.WriteLine("24 saatlik format:" + time24);
}
else
{
    Console.WriteLine("Geçersiz saat formatı!");
}




