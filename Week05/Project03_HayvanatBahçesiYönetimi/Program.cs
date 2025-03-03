namespace Project03_HayvanatBahçesiYönetimi;

class Program
{
    static void Main(string[] args)
    {
        Animal myAnimal=new Animal();
        Animal myLion=new Lion();
        Animal myMonkey=new Monkey();
        Animal myCow=new Cow();
        Animal myFly=new Fly();
        Animal mySnake=new Snake();
        myLion.species="Birçok türü vardır";
        myMonkey.species="Uzun burunlu maymun";
        myCow.species="Angus";
        myFly.species="Karasinek";
        mySnake.species="Piton yılanı";

        myLion.Name="lotus";
        myMonkey.Name="atıllık";
        myCow.Name="pullu";
        myFly.Name="tatlı";
        mySnake.Name="yeşilli";

        myLion.sound="Kükreme";
        myMonkey.sound="Ua,Ua";
        myCow.sound="Mö,Mö";
        myFly.sound= "Vız,Vız";
        mySnake.sound="Tıs,Tıs";

        myLion.MakeSound();
        myMonkey.MakeSound();
        myCow.MakeSound();
        myFly.MakeSound();
        mySnake.MakeSound();

        Console.WriteLine($"Lion: \n İsmi:{myLion.Name} \nTürü:{myLion.species} \n Ses:{myLion.sound}");
        Console.WriteLine($"Monkey: \n İsmi:{myMonkey.Name}\nTürü:{myMonkey.species}\n Ses:{myMonkey.sound}");
        Console.WriteLine($"Cow: \n İsmi:{myCow.Name} \nTürü:{myCow.species} \n Ses:{myCow.sound}");
        Console.WriteLine($"Fly:\n İsmi:{myFly.Name}\nTürü:{myFly.species} \n Ses:{myFly.sound}");
        Console.WriteLine($"Snake:\n İsmi:{mySnake.Name}\nTürü:{mySnake.species}\n Ses:{mySnake.sound}");
        
    }
}
