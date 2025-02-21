int sayac =0;
for (int sayı = 2; sayı <=100;sayı++)
{
    int kontrol=0;
    for (int i = 2; i <sayı; i++)
    if (sayı % i==0)
    {
        kontrol = 1;
        break;
    }
    if (kontrol ==1)
    {
        Console.WriteLine("{0} asal değildir",sayı);
    }
    else
    {
        Console.WriteLine("{0} asaldır",sayı);
        sayac ++;
    }
    {
        
    }


}
