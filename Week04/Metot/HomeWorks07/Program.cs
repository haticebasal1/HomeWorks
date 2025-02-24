using System.Reflection.Emit;

namespace HomeWorks07;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir saat,dakika ve saniye giriniz:");
        string [] inputs = Console.ReadLine()!.Split(' ');
        if (inputs.Length ==3 &&
        int.TryParse(inputs[0],out int hour)&&
        int.TryParse(inputs[1],out int minute) &&
       int.TryParse(inputs[2],out int second ))
        {
            string time = times (hour,minute,second);
            Console.WriteLine("Formatlı zaman:"+time);
        }
        else
        {
            Console.WriteLine(" Hatalı!!");
        }
    }
    static string times(int hour, int minute, int second)
    {
       return $"{hour:D2}:{minute:D2}:{second:D2}";
    }
}
