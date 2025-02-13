System.Console.WriteLine("Bir cümle giriniz: ");
string one = Convert.ToString(Console.ReadLine()!);
string[] parca = one.Split(' ');
System.Console.WriteLine("Girilen cümle içerisindeki kelime sayısı = " + parca.Length);
Console.ReadLine();
