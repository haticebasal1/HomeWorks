int[] number =[2,-1,3,-4,5,-6,7,-8,9,-10 ];
int[] numbers = number.Where(n=> n <0).ToArray();
int [] numbers2 = number.Where(n=> n>0).ToArray();
int i=0;
Console.WriteLine("Birinci dizi:");
while (i<number.Length)
{
    Console.Write(number[i]+" ");
    i++;
}
Console.WriteLine("İkinci dizi: ");
int j = 0;
while (j<numbers.Length)
{
    Console.Write(numbers[j]+" ");
    j++;
}
int s =0;
Console.WriteLine("Üçüncü dizi: ");
while (s<numbers2.Length)
{
    Console.Write(numbers2[s]+" ");
    s++;
}