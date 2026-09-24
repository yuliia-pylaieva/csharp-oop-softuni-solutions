namespace CustomStack;

public static class StartUp
{
     public static void Main()
    {
        StackOfStrings stack = new StackOfStrings();
        Console.WriteLine($"Empty: {stack.IsEmpty()}");
        stack.AddRange(new List<string>() { "Yulia", "Ivan", "Dimitar", "Petar" });
        Console.WriteLine($"Empty: {stack.IsEmpty()}");
        
        while(!stack.IsEmpty())
        {
            Console.WriteLine(stack.Pop());
        }
        Console.WriteLine($"Empty: {stack.IsEmpty()}");
    }
}
