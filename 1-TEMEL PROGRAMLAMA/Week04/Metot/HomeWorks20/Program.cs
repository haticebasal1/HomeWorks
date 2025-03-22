using System.Text;

namespace HomeWorks20;

class Program
{
    static string ConvertStringArrayToString(string[]array)
    {
        StringBuilder builder = new StringBuilder();
        foreach (string value in array)
        {
            builder.Append(value);
            builder.Append(' ');
        }
        return builder.ToString();
    }
    static string ConvertStringArrayToStringJoin(string[]array)
    {
        string result = string.Join(" ",array);
        return result;
    }

    static void Main()
    {
       string[]array = new string[5];
       array[0]="Bugün";
       array[1]="hava";
       array[2]="durumu";
       array[3]="çok";
       array[4]="bulutlu.";
       string result1=ConvertStringArrayToString(array);
       string result2=ConvertStringArrayToStringJoin(array);
       Console.WriteLine(result1);
       Console.WriteLine(result2);
    }
}
