namespace AbstractionLab;

public class Waiter : IOrderable, IEmployee
{
    // public Waiter(string name, int age, decimal salary)
    // {
    //    Name = name;
    //    Age = age;
    //    Salary = salary;
    // }

    public string Name { get; set; }
    public int Age { get; set; }
    public decimal Salary { get; set; }
    public int Number { get; set; }

    public void Order(string menuItemName)
    {
        Console.WriteLine($"Here is your {menuItemName}");
    }
}