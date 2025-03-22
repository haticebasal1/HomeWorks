int sayi, sonuc = 0;
            Console.Write("Sayı Girin : ");
            sayi = Convert.ToInt32(Console.ReadLine());
            while (sayi > 0)
            {
                sonuc += (sayi % 10);
                sayi = sayi / 10;
            }
            Console.WriteLine("Girdiğiniz Sayının Rakamları Toplamı : "+sonuc);
            

