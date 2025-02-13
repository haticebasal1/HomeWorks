System.Console.WriteLine("Bir cümle giriniz:");
string sentence = Convert.ToString(Console.ReadLine()!);
System.Console.WriteLine($"Küçük harf: {sentence.ToLower()}");
System.Console.Write($"Büyük harf: {sentence.ToUpper()}");

