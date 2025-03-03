using System;

namespace Project03_HayvanatBahçesiYönetimi;

public class Animal
{
public virtual string species { get; set; }=string.Empty;
public virtual string Name { get; set; }=string.Empty;
public virtual string sound { get; set; }=string.Empty;
public virtual void MakeSound()
{
    Console.WriteLine("Hayvan ses çıkardı.");
}
}
public class Lion:Animal
{
    public override string species {get=>base.species;set=>base.species=value;}
    public override string Name { get => base.Name.ToUpper(); set => base.Name = value; }
    public override string sound { get => base.sound; set => base.sound = value; }
    public override void MakeSound()
    {
        Console.WriteLine("Kükreme sesi çıkarır.");
    }
}
public class Monkey:Animal
{
    public override string species {get=>base.species;set=>base.species=value;}
    public override string Name { get => base.Name.ToUpper(); set => base.Name = value; }
    public override string sound { get => base.sound; set => base.sound = value; }
    public override void MakeSound()
    {
        Console.WriteLine("Ua,Ua sesi çıkarır.");
    }
}
public class Cow:Animal
{
    public override string species {get=>base.species;set=>base.species=value;}
    public override string Name { get => base.Name.ToUpper(); set => base.Name = value; }
    public override string sound { get => base.sound; set => base.sound = value; }
    public override void MakeSound()
    {
        Console.WriteLine("Mö,Mö sesi çıkarır.");
    }
}
public class Fly:Animal
{
    public override string species {get=>base.species;set=>base.species=value;}
    public override string Name { get => base.Name.ToUpper(); set => base.Name = value; }
    public override string sound { get => base.sound; set => base.sound = value; }
    public override void MakeSound()
    {
        Console.WriteLine("Vız,vız sesi çıkarır.");
    }
}
public class Snake:Animal
{
    public override string species {get=>base.species;set=>base.species=value;}
    public override string Name { get => base.Name.ToUpper(); set => base.Name = value; }
    public override string sound { get => base.sound; set => base.sound = value; }
    public override void MakeSound()
    {
        Console.WriteLine("Tıs,Tıs sesi çıkarır.");
    }
}