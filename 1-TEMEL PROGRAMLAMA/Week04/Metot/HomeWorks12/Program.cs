namespace HomeWorks12;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir tarih giriniz:");
        DateTime date=DateTime.Parse(Console.ReadLine()!);
          string result;
     switch (date.DayOfWeek)
     {
         case DayOfWeek.Monday:
         result="Pazartesi";
         break;
         case DayOfWeek.Tuesday:
        result="Salı";
         break;
        case DayOfWeek.Wednesday:
         result="Çarşamba";
         break;
         case DayOfWeek.Thursday:
         result="Perşembe";
        break;
         case DayOfWeek.Friday:
         result="Cuma";
        break;
         case DayOfWeek.Saturday:
         result="Cumartesi";
        break;
         default:
        result="Pazar";
        break;
    }
   Console.WriteLine("Girdiğiniz tarih :"+date.ToShortDateString());
   Console.WriteLine("Bu gün:"+result);
    }
    
}
