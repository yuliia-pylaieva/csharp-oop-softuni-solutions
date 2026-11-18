namespace FoodShortage;

public static class Program
{
    public static void Main()
    {
        try
        {
            var number = int.Parse(ReadRequiredLine());
            var buyers = ReadBuyers(number);

            var name = ReadRequiredLine();

            while (name != "End")
            {
                if (buyers.TryGetValue(name, out var buyer))
                {
                    buyer.BuyFood();
                }
                name = ReadRequiredLine();
            }
            var totalFood = buyers.Values.Sum(b => b.Food);
            Console.WriteLine(totalFood);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
        }
    }

    private static Dictionary<string, IBuyer> ReadBuyers(int number)
    {
        var result = new Dictionary<string, IBuyer>();
        for (var i = 0; i < number; i++)
        {
            var data = ReadRequiredLine().Split();
            var name = data[0];
            if (data.Length == 4)
            {
                result[name] = new Citizen(name, int.Parse(data[1]), data[2], data[3]);
            }
            else if (data.Length == 3)
            {
                result[name] = new Rebel(name, int.Parse(data[1]), data[2]);
            }
        }
        return result;
    }


    private static string ReadRequiredLine()
    {
        var line = Console.ReadLine();
        return string.IsNullOrWhiteSpace(line)
            ? throw new ArgumentException("Input cannot be null, empty or whitespace.")
            : line;
    }
}
