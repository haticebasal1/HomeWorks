Console.WriteLine("Notunuzu Giriniz:");
byte not=byte.Parse(Console.ReadLine()!);
string noteGroup ;
if (not<0)
{
noteGroup = "YE,YS,DS";
}
else if (not<=39)
{
    noteGroup =$"FF";
}
else if (not<=49)
{
    noteGroup=$"FD";
}
else if (not<=54)
{
    noteGroup =$"DD";
}
else if (not<=59)
{
    noteGroup=$"DC";
}
else if (not<=69)
{
    noteGroup = $"CC";
}
else if (not<=79)
{
    noteGroup = $"CB";
}
else if (not<=84)
{
    noteGroup = $"BB";
}
else if (not<=89)
{
    noteGroup = $"BA";
}
else
{
 noteGroup = $"AA";
}


  
Console.WriteLine(noteGroup);