using System;

namespace Odev1_Racing_Simulation
{
    public class Car
    {
       public Car(string brand, string model)
        {
            Brand = brand;
            Model = model;
            Speed = 0;
            FuelLevel = 100;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }
        public int FuelLevel { get; set; }

        public void Accelerate(int increment)
        {
            if (FuelLevel > 0)
            {
                Speed += increment;
                ConsumeFuel(increment);
            }
            else
            {
                Console.WriteLine($"{Brand} {Model} aracının yakıtı bittiği için hızlanamıyor. Yarıştan çıkarıldı!");
            }
        }

        public void Brake(int decrement)
        {
            Speed = Math.Max(0, Speed - decrement);
        }

        public void ConsumeFuel(int amount)
        {
            FuelLevel = Math.Max(0, FuelLevel - amount);
            if (FuelLevel == 0)
            {
                Console.WriteLine($"{Brand} {Model} aracının yakıtı bitti!");
            }
        }

        public void DisplayStatus()
        {
            Console.WriteLine($"{Brand} {Model} ARACI\nHIZ: {Speed} km/s, YAKIT: {FuelLevel}%");
            Console.WriteLine("--------------------------------");
        }
    }
}

