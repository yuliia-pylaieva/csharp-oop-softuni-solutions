namespace Demos;

public class LemonCake : IRecipe
{
    public void GetIngredients()
    {
        Console.WriteLine("Get flour and sugar");
        Console.WriteLine("Get butter and eggs");
        Console.WriteLine("Get lemons");
        Console.WriteLine("Get baking powder");
    }

    public void Mix()
    {
        Console.WriteLine("Beat the butter and sugar together");
        Console.WriteLine("Add the eggs, lemon juice and lemon zest");
        Console.WriteLine("Fold in the flour and baking powder");
    }

    public void Prepare()
    {
        Console.WriteLine("Pour the batter into a cake tin");
        Console.WriteLine("Put in the oven for 40 minutes on 180 degrees");
    }
}
