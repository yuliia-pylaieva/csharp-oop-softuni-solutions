using System;

namespace Animals;

public class Animal
{
    //Validation
    //if using get-only properties -> validation in constructor
    //if using get;set; properties -> validation in setter
    private string _gender;
    public Animal(string name, int age, string gender)
    {
        if(string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Name cannot be null or whitespace.");
        Name = name;
        if(age < 0) throw new ArgumentException("Age cannot be below zero.");
        Age = age;
        
        Gender = gender;
    }

    public string Name {get;}

    public string Gender
    {
        get => _gender;
        
        //validation in setter
        set
        {
            if(string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Gender cannot be null or whitespace.");
            _gender = value;
        }
    }
    public int Age { get; }
    
    //better to use abstract method instead of virtual
    
    public virtual string ProduceSound() => "";
    
    
}