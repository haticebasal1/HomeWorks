namespace Odev3_Zoo_Management;

class Program
{
    static void Main(string[] args)
    {
        Animal[] animals = [
            new Lion("Aslan","Simba"),
            new Elephant("Fil","Muhittin"),
            new Monkey("Maymun","Dombo"),
            new Lion("Aslan","Cumba"),
            new Monkey("Maymun","Jerry")
        ];

        foreach (Animal nextAnimal in animals)
        {
            nextAnimal.MakeSound();
        }
    }
}
