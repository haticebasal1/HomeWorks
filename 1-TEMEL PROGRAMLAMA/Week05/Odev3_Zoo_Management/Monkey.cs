using System;

namespace Odev3_Zoo_Management
{
    public class Monkey : Animal
    {
        public Monkey(string species, string name) : base(species, name)
        {
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} ({Species}) ses çıkarıyor: UUUHH OOHHH UUUHH AAHHHH!");
        }
    }
}
