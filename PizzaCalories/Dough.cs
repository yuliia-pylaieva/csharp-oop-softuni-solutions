using PizzaCalories.Enums;

namespace PizzaCalories;

public class Dough
{
    private const double BaseCaloriesModifier = 2;
    private const int MinWeight = 1;

    private const int MaxWeight = 200;
    // static  - you create 1 instance per class // if no static, you will create a new instance per instance

    private static readonly Dictionary<FlourType, double> _flourModifiers = new()
    {
        { FlourType.Wholegrain, 1 },
        { FlourType.White, 1.5 }
    };

    private static readonly Dictionary<BakingTechnique, double> _bakingModifiers = new()
    {
        { BakingTechnique.Chewy, 1.1 },
        { BakingTechnique.Homemade, 1 },
        { BakingTechnique.Crispy, 0.9 }
    };

    public Dough(string flourType, string bakingTechnique, int weight)
    {
        if (!Enum.TryParse<FlourType>(flourType, true, out var flourTypeValue) ||
            !Enum.IsDefined(flourTypeValue) ||
            !Enum.TryParse<BakingTechnique>(bakingTechnique, true, out var bakingTechniqueValue) ||
            !Enum.IsDefined(bakingTechniqueValue))
            throw new ArgumentException("Invalid type of dough.");
        if (weight < MinWeight || weight > MaxWeight)
            throw new ArgumentException($"Dough weight should be in the range [{MinWeight}..{MaxWeight}].");
        Weight = weight;
        FlourType = flourTypeValue;
        BakingTechnique = bakingTechniqueValue;
    }

    public FlourType FlourType { get; }
    public BakingTechnique BakingTechnique { get; }
    public int Weight { get; }

    public double CalculateCalories()
    {
        return BaseCaloriesModifier * Weight * _flourModifiers[FlourType] * _bakingModifiers[BakingTechnique];
    }
}

//for dictionaries with strings, we can use String.Comparer.OriginalIgnoreCase 