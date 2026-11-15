// See https://aka.ms/new-console-template for more information

namespace PizzaCalories;

public static class Program
{
    public static void Main()
    {
        try
        {
            var command = Console.ReadLine();
            Pizza? pizza = null;
            while (command != "END")
            {
                var commandArgs = command.Split();
                if (commandArgs[0] == "Pizza")
                {
                    pizza = new Pizza(commandArgs[1]);
                }
                else if (commandArgs[0] == "Dough")
                {
                    if (pizza is null) throw new InvalidOperationException("Create a pizza first!");
                    pizza.Dough = new Dough(commandArgs[1], commandArgs[2], int.Parse(commandArgs[3]));
                }
                else if (commandArgs[0] == "Topping")
                {
                    if (pizza is null) throw new InvalidOperationException("Create a pizza first!");
                    pizza.AddTopping(new Topping(commandArgs[1], int.Parse(commandArgs[2])));
                }

                command = Console.ReadLine();
            }

            if (pizza is not null)
                Console.WriteLine($"{pizza.Name} - {pizza.TotalCalories:f2} Calories.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}