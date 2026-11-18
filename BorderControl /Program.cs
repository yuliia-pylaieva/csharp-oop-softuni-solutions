// See https://aka.ms/new-console-template for more information

namespace BorderControl;

//Birthday Celebrations and BorderControl solutions in one project

public static class Program
{
    private const string EmptyInputMessage = "Input cannot be null, empty or whitespace.";
    private const string EmptyOutput = "";

    public static void Main(string[] args)
    {
        try
        {
            var entities = new List<IEntity>();

            var input = ReadRequiredLine();

            while (input != "End")
            {
                var data = input.Split();
                if (data[0] == "Citizen" && data.Length == 5)
                {
                    entities.Add(new Citizen(data[1], ParseAge(data[2]), data[3], data[4]));
                }
                else if (data[0] == "Pet" && data.Length == 3)
                {
                    entities.Add(new Pet(data[1], data[2]));
                }
                else if (data[0] == "Robot" && data.Length == 3)
                {
                    entities.Add(new Robot(data[1], data[2]));
                }

                input = ReadRequiredLine();
            }

            var suffix = ReadRequiredLine();

            PrintResult("birthdate", entities, suffix);
            suffix = ReadRequiredLine();
            PrintResult("id", entities, suffix);

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    private static void PrintResult(string type, IEnumerable<IEntity> entities, string suffix)
    {
        var printType = type.ToLowerInvariant();

        if (printType == "id")
        {
            PrintMatches(entities.OfType<IIdentifiable>().Select(e => e.Id), suffix);
        }
        else if (printType == "birthdate")
        {
            PrintMatches(entities.OfType<ILivable>().Select(e => e.Birthdate), suffix);
        }
        else
        {
            throw new ArgumentException("Invalid print type. Use \"id\" or \"birthdate\".");
        }
    }

    private static void PrintMatches(IEnumerable<string> values, string suffix)
    {
        var matches = values.Where(v => v.EndsWith(suffix, StringComparison.Ordinal)).ToList();

        if (matches.Count == 0)
        {
            Console.WriteLine(EmptyOutput);
            return;
        }

        matches.ForEach(Console.WriteLine);
    }

    private static int ParseAge(string value) =>
        int.TryParse(value, out var age) ? age : throw new ArgumentException("Invalid age");

    private static string ReadRequiredLine()
    {
        var line = Console.ReadLine();
        return string.IsNullOrWhiteSpace(line) ? throw new ArgumentException(EmptyInputMessage) : line;
    }
}
