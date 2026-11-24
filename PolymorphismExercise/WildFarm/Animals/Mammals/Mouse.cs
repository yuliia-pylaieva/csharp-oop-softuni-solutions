using WildFarm.Foods;
using WildFarm.Interfaces;

namespace WildFarm.Animals.Mammals;

public class Mouse : BaseMammal
{
    public Mouse(string name, double weight, string livingRegion) : base(name, weight, livingRegion)
    {
    }

    protected override double GrowthFactor => 0.1;
    public override string AskForFood() => "Squeak";
    public override bool EatFood(IFood food) => (food is Vegetable || food is Fruit) && base.EatFood(food);
}