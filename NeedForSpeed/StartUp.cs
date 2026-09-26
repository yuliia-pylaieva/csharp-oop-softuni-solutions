using System;

namespace NeedForSpeed;

public class StartUp
{
    public static void Main(string[] args)
    {
        var raceMotorcycle = new RaceMotorcycle(fuel: 5, horsePower: 200);
        Console.WriteLine(raceMotorcycle);
        
        var crossMotorcycle = new CrossMotorcycle(fuel:7, horsePower: 300);
        Console.WriteLine(crossMotorcycle);

        var familyCar = new FamilyCar(fuel: 4, horsePower: 80);
        Console.WriteLine(familyCar);
    }
}