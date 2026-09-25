using System;

namespace Person;

public class StartUp
{
    public static void Main(string[] args)
    {
        var name = Console.ReadLine();

        var age = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());


        if (age < 0)

        {
            Console.WriteLine("Age must be positive!");
        }

        else if (age > 15)

        {
            var person = new Person(name, age);

            Console.WriteLine(person);
        }

        else

        {
            var child = Child.CreateInstance(name, age);

            Console.WriteLine(child);
        }
    }
}