namespace CustomStack;

public class StartUp
{
     public static void Main()
    {
        StackOfStrings stack = new StackOfStrings();
        Console.WriteLine(stack.IsEmpty());
        stack.AddRange(new List<string>() { "Yulia", "Ivan", "Dimitar", "Petar" });
        Console.WriteLine(stack.IsEmpty());
        
        while(!stack.IsEmpty())
        {
            Console.WriteLine(stack.Pop());
        }
    }
}
