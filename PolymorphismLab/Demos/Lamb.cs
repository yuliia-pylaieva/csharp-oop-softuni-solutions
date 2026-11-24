namespace Demos;

public class Lamb : IRecipe
{
    public void GetIngredients()
    {
       Console.WriteLine("Get salt and pepper");
       Console.WriteLine("Get lamb leg");
       Console.WriteLine("Get oil");
    }

    public void Mix()
    {
        Console.WriteLine("Put together the salt, oil and pepper");
        Console.WriteLine("Rub the meat");
    }

    public void Prepare()
    {
       Console.WriteLine("Put in the oven for 4 hours on 180 degrees");
    }
}