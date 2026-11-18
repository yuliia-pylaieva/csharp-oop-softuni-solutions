using PizzaCalories.Enums;

namespace PizzaCalories;

public class Topping
{
    private const int MinWeight = 1;
    private const int MaxWeight = 50;
    private const double BaseCaloriesModifier = 2;

    private static readonly Dictionary<ToppingType, double> _toppingTypeModifiers = new()
    {
        { ToppingType.Cheese, 1.1 },
        { ToppingType.Sauce, 0.9 },
        { ToppingType.Veggies, 0.8 },
        { ToppingType.Meat, 1.2 }
    };

    public Topping(string toppingType, int weight)
    {
        if (!Enum.TryParse<ToppingType>(toppingType, true, out var toppingTypeValue) ||
            !Enum.IsDefined(toppingTypeValue))
            throw new ArgumentException($"Cannot place {toppingType} on top of your pizza.");

        if (weight < MinWeight || weight > MaxWeight)
            throw new ArgumentException(
                $"{toppingTypeValue} weight should be in the range [{MinWeight}..{MaxWeight}].");
        ToppingType = toppingTypeValue;
        Weight = weight;
    }

    public ToppingType ToppingType { get; }
    public int Weight { get; }

    public double CalculateCalories()
    {
        return BaseCaloriesModifier * Weight * _toppingTypeModifiers[ToppingType];
    }
}