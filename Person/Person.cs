namespace Person;

public class Person
{
    private int _age;

    //full property - field+property - > get;set;
    //auto property - property, no field -> get;
    private string _name;

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public string Name { get; set; }
    public int Age { get; set; }

    public override string ToString()

    {
        return $"{GetType().Name} -> Name: {Name}, Age: {Age}";
    }
}