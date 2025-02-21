int [] number =[ 2, 4, 6, 7, 10, 13, 12, 19, 21, 23];
for (int i = 0; i < number.Length; i++)
{
    if (i> 0 && i <number.Length-1)
    {
        Console.WriteLine($"{number[i]}:Önceki = {number[i-1]},Sonraki ={number[i+1]}");
    }
    else if (i== 0 )
    {
        Console.WriteLine($"{number[i]}:İlk Eleman,sonraki ={number[i+1]}");
    }
    else if (i == number.Length -1)
    {
        Console.WriteLine($"{number[i]}: Son eleman, sadece önceki ={number[i-1]}");
    }
}