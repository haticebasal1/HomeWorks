int  [] number = [2,3,1,4,6,8,10,23,12,14];
Console.WriteLine("Çift sayılar:");
foreach (int num in number)
{
    if (num % 2 == 0) 
    Console.Write(num + " ");
}

      Console.WriteLine("\nTek sayılar:");
foreach (int num in number)
{
    if (num % 2 != 0) 
    Console.Write(num + " ");
}
Array.Sort(number);
Console.WriteLine("\nSıralı dizi:");
foreach (int num in number)
{
    Console.Write(num + " ");
}



	