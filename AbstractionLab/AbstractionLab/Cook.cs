namespace AbstractionLab;

public class Cook : IOrderable, IEmployee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public decimal Salary { get; set; }
    public int Number { get; set; }

    public void Order(string menuItemName)
    {
        Console.WriteLine($"Preparing your {menuItemName}");
    }
}