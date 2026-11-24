using WildFarm.Foods;
using WildFarm.Interfaces;

namespace WildFarm.Animals.Mammals.Feline;

public class Cat : BaseFeline
{
    public Cat(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
    {
    }
    protected override double GrowthFactor => 0.3;
    public override string AskForFood() => "Meow";
    public override bool EatFood(IFood food) => (food is Vegetable || food is Meat) && base.EatFood(food);
}