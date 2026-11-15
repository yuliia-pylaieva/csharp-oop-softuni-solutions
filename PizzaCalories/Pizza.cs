namespace PizzaCalories;

public class Pizza
{
    private const int MaxNameLength = 15;
    private const int MaxToppingsCount = 10;
    private readonly List<Topping> _toppings;

    public Pizza(string name)
    {
        if (string.IsNullOrWhiteSpace(name) || name.Length > MaxNameLength)
            throw new ArgumentException($"Pizza name should be between 1 and {MaxNameLength} symbols.");
        Name = name;
        _toppings = new List<Topping>();
    }

    public string Name { get; }
    public Dough? Dough { get; set; }

    public int ToppingsCount => _toppings.Count;
    public double TotalCalories => CalculateTotalCalories();

    public void AddTopping(Topping topping)
    {
        if (_toppings.Count == MaxToppingsCount)
            throw new InvalidOperationException($"Number of toppings should be in range [0..{MaxToppingsCount}].");
        _toppings.Add(topping);
    }

    private double CalculateTotalCalories()
    {
        double totalCalories = 0;
        if (Dough != null) totalCalories += Dough.CalculateCalories();
        totalCalories += _toppings.Sum(t => t.CalculateCalories());
        return totalCalories;
    }
}