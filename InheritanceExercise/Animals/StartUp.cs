using System;

namespace Animals;

public class StartUp
{
    public static void Main(string[] args)
    {
        var animalType = Console.ReadLine();

        while (animalType != "Beast!")
        {
            string[] data = Console.ReadLine().Split();

            Animal animal = null;
            switch (animalType)
            {
                case "Dog":
                    animal = new Dog(data[0], int.Parse(data[1]), data[2]);
                    break;
                case "Cat":
                    animal = new Cat(data[0], int.Parse(data[1]), data[2]);
                    break;
                case "Frog":
                    animal = new Frog(data[0], int.Parse(data[1]), data[2]);
                    break;
                case "Kitten":
                    animal = new Kitten(data[0], int.Parse(data[1]));
                    break;
                case "Tomcat":
                    animal  = new Tomcat(data[0], int.Parse(data[1]));
                    break;
                default:
                    break;
            }

            if (animal is not null)
            {
                Console.WriteLine(animal.ProduceSound());
            }
            else
            {
                animalType = Console.ReadLine();
            }
           
        }

    }
}