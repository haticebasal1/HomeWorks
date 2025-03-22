using System;

namespace Odev5_Grade_Management
{
    public abstract class Person
    {
          public Person(string name)
        {
            Name = name;
        }
        public string Name { get; set; }

        public abstract void DisplayInfo();
    }
}
