using System.Reflection.Metadata.Ecma335;

namespace ExplicitInterfaces;

public class Citizen : IPerson, IResident
{
    public Citizen(string name, string country, int age)
    {
        Name = name;
        Country = country;
        Age = age;
    }

    public string Name { get; private set; }
    public string Country { get; }
    public int Age { get; }

    string IResident.Name => $"Mr/Ms/Mrs {this.Name}";
    string IPerson.Name => $"{this.Name}";
}