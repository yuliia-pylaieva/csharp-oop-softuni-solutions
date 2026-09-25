namespace Person;

public class Child : Person
{
    public Child(string name, int age) : base(name, age)
    {
    }

    public static Child CreateInstance(string name, int age)
    {
        return new Child(name, age);
    }
}