namespace Demos;

public class Musaka : IRecipe
{
    public void GetIngredients()
    {
        Console.WriteLine("Get potatoes");
        Console.WriteLine("Get minced meat");
        Console.WriteLine("Get onion");
        Console.WriteLine("Get eggs and yogurt");
    }

    public void Mix()
    {
        Console.WriteLine("Fry the onion and minced meat");
        Console.WriteLine("Layer sliced potatoes and the meat in a baking dish");
        Console.WriteLine("Whisk the eggs with the yogurt");
    }

    public void Prepare()
    {
        Console.WriteLine("Pour the egg and yogurt topping over the dish");
        Console.WriteLine("Put in the oven for 1 hour on 200 degrees");
    }
}
