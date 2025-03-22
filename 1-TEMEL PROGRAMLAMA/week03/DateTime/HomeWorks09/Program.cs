System.Console.WriteLine("Bir tarih giriniz:");
string inputDate1 = Console.ReadLine()!;

System.Console.WriteLine("İkinci tarih giriniz:");
string inputDate2 = Console.ReadLine()!;

if (DateTime.TryParse(inputDate1, out DateTime date1)&& DateTime.TryParse(inputDate2, out DateTime date2))
{
    if (date1<date2)
    {
        Console.WriteLine("Birinci tarih, ikinci tarihten önce ");
    }
   else if (date1>date2)
   {
    Console.WriteLine("Birinci tarih, ikinci tarihten sonra ");
   }
    else
    {
        Console.WriteLine("İki tarih aynıdır.");
    }
}



