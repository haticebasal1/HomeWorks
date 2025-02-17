Console.WriteLine("Notunuzu Giriniz:");
byte not=byte.Parse(Console.ReadLine()!);
string noteGroup =not<0?"YE,YS,DS": not<=39?"FF": not<=49?"FD":not<=54?"DD":not<=59?"DC":not<=69?"CC":not<=79?"CB":not<=84?"BB":not<=89?"BA":"AA";
Console.WriteLine(noteGroup);
