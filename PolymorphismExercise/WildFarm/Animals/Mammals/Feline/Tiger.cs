using WildFarm.Foods;
using WildFarm.Interfaces;

namespace WildFarm.Animals.Mammals.Feline;

public class Tiger : BaseFeline
{
    public Tiger(string name, double weight, string livingRegion, string breed) : base(name, weight, livingRegion, breed)
    {
    }

    protected override double GrowthFactor => 1;
    public override string AskForFood() => "ROAR!!!";
    
    public override bool EatFood(IFood food) => food is Meat && base.EatFood(food);
}