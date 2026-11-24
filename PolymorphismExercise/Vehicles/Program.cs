using System.Globalization;

namespace Vehicles;

public static class Program
{
    public static void Main()
    {
        try
        {
            var carInput = ReadRequiredLine().Split();
            double carFuel = ParseDouble(carInput[1]);
            double carConsumption = ParseDouble(carInput[2]);
            double carTankCapacity = ParseDouble(carInput[3]);
            var car = new Car(carFuel, carConsumption, carTankCapacity);

            var trunkInput = ReadRequiredLine().Split();
            double truckFuel = ParseDouble(trunkInput[1]);
            double truckConsumption = ParseDouble(trunkInput[2]);
            double truckTankCapacity = ParseDouble(trunkInput[3]);
            var truck = new Truck(truckFuel, truckConsumption, truckTankCapacity);
            
            var busInput = ReadRequiredLine().Split();
            double busFuel = ParseDouble(busInput[1]);
            double busConsumption = ParseDouble(busInput[2]);
            double busTankCapacity = ParseDouble(busInput[3]);
            var bus = new Bus(busFuel, busConsumption, busTankCapacity);

            Dictionary<string, IVehicle> vehiclesByType = new Dictionary<string, IVehicle>()
            {
                [nameof(Car)] = car,
                [nameof(Truck)] = truck,
                [nameof(Bus)] = bus
            };

            int commandsCount = ParseInt(ReadRequiredLine());
            for (int i = 0; i < commandsCount; i++)
            {
                var command = ReadRequiredLine().Split();
                if (command.Length < 3 || !vehiclesByType.TryGetValue(command[1], out var vehicle))
                {
                    throw new FormatException("Invalid input");
                }
                string commandType = command[0];
                string vehicleType = command[1];

                // Business-rule errors are reported per command; processing continues.
                try
                {
                    if (commandType == "Drive")
                    {
                        DriveVehicle(vehicleType, vehicle, ParseDouble(command[2]), false);
                    }
                    else if (commandType == "DriveEmpty")
                    {
                        DriveVehicle(vehicleType, vehicle, ParseDouble(command[2]), true);
                    }
                    else if (commandType == "Refuel")
                    {
                        var liters = ParseDouble(command[2]);
                        if (!vehicle.Refuel(liters))
                        {
                            Console.WriteLine($"Cannot fit {liters} fuel in the tank");
                        }
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private static void DriveVehicle(string vehicleType, IVehicle vehicle, double distance, bool ecoMode )
    {
        Console.WriteLine(vehicle.Drive(distance, ecoMode)
            ? $"{vehicleType} travelled {distance} km"
            : $"{vehicleType} needs refueling");
    }

    // Reads a line from the console; throws on null (end of input) or whitespace-only lines.
    private static string ReadRequiredLine()
    {
       string? input = Console.ReadLine();
       return string.IsNullOrWhiteSpace(input) ? throw new ArgumentException("Invalid input") : input;
    }

    // Parses a double using the invariant culture; throws if it is not a valid number.
    private static double ParseDouble(string input)
    {
        return! double.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out double result) 
                ? throw new FormatException($"Invalid number: {input}") : result;
    }

    // Parses an int using the invariant culture; throws if it is not a valid integer.
    private static int ParseInt(string input)
    {
        return !int.TryParse(input, NumberStyles.Integer, CultureInfo.InvariantCulture, out int result) 
            ? throw new FormatException($"Invalid integer: {input}") : result;
    }
}