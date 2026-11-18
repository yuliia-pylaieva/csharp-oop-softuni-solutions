// See https://aka.ms/new-console-template for more information

using Cars.Models;
using Cars.Models.Interfaces;

namespace Cars;

public static class StartUp
{
    public static void Main(string[] args)
    {
        ICar seat = new Seat("Leon", "Grey");

        ICar tesla = new Tesla("Model 3", "Red", 2);

        Console.WriteLine(seat.ToString());
        Console.WriteLine(tesla.ToString());
        Console.WriteLine(seat.Start());
        Console.WriteLine(tesla.Stop());
    }
}