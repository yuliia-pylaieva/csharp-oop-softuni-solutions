using System;

public class Chicken
{
    private const int MinAge = 0;
    private const int MaxAge = 15;
    private int _age;

    private string _name;

    public Chicken(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public string Name
    {
        get => this._name;
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException($"{nameof(Name)} cannot be empty.");
            }

            this._name = value;
        }
    }

    public int Age
    {
        get => this._age;
        private set
        {
            if (value < MinAge || value > MaxAge)
            {
                throw new ArgumentException($"{nameof(Age)} should be between {MinAge} and {MaxAge}.");
            }

            this._age = value;
        }
    }

    public double ProductPerDay => CalculateProductPerDay();

    private double CalculateProductPerDay()
    {
        return this.Age switch
        {
            <= 3 => 1.5,
            <= 7 => 2,
            <= 11 => 1,
            _ => 0.75
        };
    }
}