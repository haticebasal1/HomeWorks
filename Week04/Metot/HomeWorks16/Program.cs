namespace HomeWorks16;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir kelime giriniz:");
        string kelime=Console.ReadLine()!;
        if (IsPalindrome(kelime))
        {
            Console.WriteLine($"{kelime} bir palindromdur.");
        }
        else
        {
            Console.WriteLine($"{kelime} bir palindrom değildir.");
        }
    }
    static bool IsPalindrome(string text)
    {
     int length = text.Length;
     for (int i = 0; i < length/2; i++)
     {
        if (text[i] != text[length-i-1])
        {
            return false;
        }
     }
     return true;
    }
}
