namespace Odev1_Racing_Simulation;

class Program
{
    static void Main(string[] args)
    {
        Car[] cars = [
            new Car("Toyota","Corolla"),
            new Car("Honda","Civic"),
            new Car("Opel","Corsa")
        ];

        Random random = new Random();
        bool raceFinished = false;
        int tour = 1;
        Console.Clear();
        while (!raceFinished)
        {
            Console.WriteLine($"********* {tour++}.TUR *********");
            Console.WriteLine("------------------------------");
            foreach (Car nextCar in cars)
            {
                if (nextCar.FuelLevel > 0)
                {
                    //Hızlandır
                    nextCar.Accelerate(random.Next(4, 21));
                    //Yavaşlatma
                    nextCar.Brake(random.Next(0, 5));
                    nextCar.DisplayStatus();
                }
            }
            bool isAllCarFuelLevelZero = true;
            foreach (Car nextCar in cars)
            {
                if (nextCar.FuelLevel != 0)
                {
                    isAllCarFuelLevelZero = false;
                }
            }
            raceFinished = isAllCarFuelLevelZero;
        }
        Console.WriteLine();
        Console.WriteLine("YARIŞ SONUCU");
        Console.WriteLine("--------------------------------");
        Car winnerCar = cars[0];
        for (int i = 1; i < cars.Length; i++)
        {
            if (cars[i].Speed > winnerCar.Speed)
            {
                winnerCar = cars[i];
            }
        }
        Console.WriteLine($"YARIŞI KAZANAN ARAÇ: {winnerCar.Brand} {winnerCar.Model}");
        Console.WriteLine($"HIZ: {winnerCar.Speed}");
    }
}
    
