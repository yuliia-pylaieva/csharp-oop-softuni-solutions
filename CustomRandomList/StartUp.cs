namespace  CustomRandomList;

public class StartUp
{
    static void Main()
    {
        RandomList list = new();
        
        list.Add("Pesho");
        list.Add("Gosho");
        list.Add("Yulia");
        
        Console.WriteLine($"Removed person from the list: {list.RandomString()} ");
        Console.WriteLine();
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }
    
}