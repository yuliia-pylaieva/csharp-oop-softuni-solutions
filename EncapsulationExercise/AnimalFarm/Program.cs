using System;

namespace AnimalFarm
{
    public static class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var name = Console.ReadLine();
                var age = int.Parse(Console.ReadLine());
                var chicken = new Chicken(name, age);
                Console.WriteLine(
                    $"Chicken {chicken.Name} (age {chicken.Age}) can produce {chicken.ProductPerDay} eggs per day.");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}