namespace Person;

public class Person
{
    
    //full property - field+property - > get;set;
    //auto property - property, no field -> get;
    private string _name;
    private int _age;
    
    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }
    
    public string Name { get; set; }
    public int Age { get; set; }
    
    public override string ToString()

    {
        return $"{this.GetType().Name} -> Name: {this.Name}, Age: {this.Age}";

    }
}