Console.Write("Bir sayı giriniz:");
int number = int.Parse(Console.ReadLine()!);

string message ;
if (number >0)
{
    message = $"{number} pozitif bir sayıdır.";
}
else if(number<0)
{
    message=$"{number} negatif bir sayıdır.";
}
else
{
    message=$"{number} 0'dır.";
}
Console.WriteLine(message);
