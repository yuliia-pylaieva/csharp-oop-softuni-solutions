using WildFarm.Interfaces;

namespace WildFarm.Animals;

public abstract class BaseAnimal : IAnimal
{
    protected BaseAnimal(string name, double weight)
    {
        Name = name;
        Weight = weight;
    }

    public string Name { get; }
    public double Weight { get; private set; }
    public int FoodEaten { get; private set; }

    protected abstract  double GrowthFactor { get; }

    public abstract string AskForFood();

    public virtual bool EatFood(IFood food)
    {
        Weight += food.Quantity * this.GrowthFactor;
        FoodEaten += food.Quantity;
        return true;
    }
}