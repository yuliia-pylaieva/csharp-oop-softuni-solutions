namespace Demos;

public class Chef
{
    public void Cook(IRecipe recipe)
    {
        recipe.GetIngredients();
        recipe.Mix();
        recipe.Prepare();
    }
}