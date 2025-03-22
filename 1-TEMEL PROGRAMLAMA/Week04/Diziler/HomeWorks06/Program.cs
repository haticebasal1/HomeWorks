int[] sayilar = new int[101]; 
Random rnd = new Random();
int enbuyuk =0, enkucuk=0;
 
for (int i = 0; i < sayilar.Length; i++)
{
    sayilar[i] = rnd.Next(1, 101);
 if (i == 0)
    {
         enbuyuk = sayilar[i];
                    enkucuk = sayilar[i];
                }
                if (sayilar[i] < enkucuk)
                {
                    enkucuk = sayilar[i];
                }
                if (sayilar[i] > enbuyuk)
                {
                    enbuyuk = sayilar[i];
                }
            }
            Console.WriteLine("Dizinin en büyük elemanı = " + enbuyuk);
            Console.WriteLine("Dizinin en küçük elemanı = " + enkucuk);


