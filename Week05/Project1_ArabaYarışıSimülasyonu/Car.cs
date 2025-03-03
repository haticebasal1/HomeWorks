using System;

namespace Project1_ArabaYarışıSimülasyonu
{
    public class Car
    {
    public string brand;
    public string model;
     int speed { get; set; }=0;
    double fuelLevel { get; set; }=100;
    
      public void Accelerate()
      {
        int rise=new Random().Next(5,30);
        speed+=rise;
        Console.WriteLine($"{brand} {model} hızlandı.Yeni hız:{speed} km/h");
      }
      public void Brake()
      {
        int decrease=new Random().Next(5,20);
        speed-=decrease;
        if (speed<0)speed=0;
        Console.WriteLine($"{brand} {model} yavaşladı.Yeni hız:{speed} km/h");
      }
      public void ConsumeFuel()
      {
        double fuelConsumption = speed*0.5;
        fuelLevel-=fuelConsumption;
        if (fuelLevel<0) fuelLevel=0;
      }
      public bool IsOutOfFuel()
      {
        return fuelLevel<=0;
      }
      public void DisPlayStatus()
      {
        Console.WriteLine($"{brand} {model}-Hız:{speed} km/h, Yakıt:{fuelLevel:F2}%");
      }
    }
}
