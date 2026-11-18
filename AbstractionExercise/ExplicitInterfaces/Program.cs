namespace ExplicitInterfaces;

public static class Program
{
    public static void Main(string[] args)
    {
        try
        {
            var input = ReadRequiredLine();
            while (input != "End")
            {
                string[] data = input.Split();
                Citizen citizen = new Citizen(data[0], data[1], ParseInt(data[2]));
                Console.WriteLine(((IPerson)citizen).Name);
                Console.WriteLine(((IResident)citizen).Name);
                input = ReadRequiredLine();
            };

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    private static string ReadRequiredLine()
    {
        var line = Console.ReadLine();
        return string.IsNullOrWhiteSpace(line)
            ? throw new ArgumentException("Input cannot be null, empty or whitespace.")
            : line;
    }
    private static int ParseInt(string value) =>
        int.TryParse(value, out var result) ? result : throw new ArgumentException("Invalid age: " + value);
}