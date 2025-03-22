using System;

namespace Odev3_Zoo_Management
{
    public abstract class Animal
    {
        public Animal(string species, string name)
        {
            Species = species;
            Name = name;
        }

        public string Species { get; set; }
        public string Name { get; set; }
        public abstract void MakeSound();
    }
}
