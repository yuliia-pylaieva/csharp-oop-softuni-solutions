using System;
using AnimalFarm.Models;

namespace AnimalFarm
{
    public static class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());

            var chicken = new Chicken(name, age);
            Console.WriteLine(
                $"Chicken {chicken.Name} (age {chicken.Age}) can produce {chicken.ProductPerDay} eggs per day.");
        }
    }
}