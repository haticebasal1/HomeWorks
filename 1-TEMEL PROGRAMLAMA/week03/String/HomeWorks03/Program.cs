Console.WriteLine("Bir cümle giriniz.");
string sentence = Console.ReadLine()!;

// Bugün hava çok güzel çok sıcak ve çok bunaltıcı.
Console.WriteLine("Hangi kelimeyi saydırmak istiyorsun?");
string word = Console.ReadLine()!;

int count = sentence.Split(word).Length-1;
Console.WriteLine(count);
