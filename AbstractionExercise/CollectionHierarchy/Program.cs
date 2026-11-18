namespace CollectionHierarchy;

public static class Program
{
    public static void Main(string[] args)
    {
        try
        {
            var items = ReadRequiredLine().Split();
            var removedElementsNumber = ParseInt(ReadRequiredLine());

            var addCollection = new AddCollection();
            var addRemoveCollection = new AddRemoveCollection();
            var myList = new MyList();


            Add(items, addCollection);
            Add(items, addRemoveCollection);
            Add(items, myList);
            Remove(removedElementsNumber, addRemoveCollection);
            Remove(removedElementsNumber, myList);

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }


    }

    private static void Add(string[] items, ISupportsAdd collection)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (i > 0) Console.Write(" ");
            Console.Write(collection.Add(items[i]));
        }
        Console.WriteLine();
    }

    private static void Remove(int count, ISupportsRemove collection)
    {
        for (int i = 0; i < count; i++)
        {
            if (i > 0) Console.Write(" ");
            Console.Write(collection.Remove());
        }
        Console.WriteLine();
    }
    private static string ReadRequiredLine()
    {
        var line = Console.ReadLine();
        return string.IsNullOrWhiteSpace(line)
            ? throw new ArgumentException("Input cannot be null, empty or whitespace.")
            : line;
    }

    private static int ParseInt(string value) =>
        int.TryParse(value, out var result) ? result : throw new ArgumentException("Invalid number: " + value);
}