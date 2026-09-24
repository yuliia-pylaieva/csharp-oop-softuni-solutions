namespace  CustomRandomList;

public static class StartUp
{
    public static void Main()
    {
        var list = new RandomList
        {
            "Pesho",
            "Gosho",
            "Yulia"
        };

        Console.WriteLine($"Removed person from the list: {list.RandomString()} ");
        Console.WriteLine();
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
    
}