namespace Person;

public class Person
{
    
    //auto property - property, no field 
    //full property - field+property - > get; set; used for fuller logic in the getter and setter
    // private string _name;
    // private int _age;
    // public string Name {
    //     get
    //     {
    //         return _name;
    //     }
    //     set
    //     {
    //         _name = value;
    //     }
    // }

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