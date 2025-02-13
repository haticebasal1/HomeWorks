System.Console.WriteLine("Bir cümle giriniz: ");
string sentence =Convert.ToString(Console.ReadLine()!);
char[] charsToTrim = {' '};
string sentence2= sentence.Trim(charsToTrim);
System.Console.WriteLine(sentence+sentence2);

