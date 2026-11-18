namespace Animals;

public class Cat : Animal
{
    public Cat(string name, int age, string gender) : base(name, age, gender)
    {
    }

    //another approach for the sound to avoid situation when base virtual method does not have implementation
    // protected Cat(string name, int age, string gender, string sound) : base(name, age, gender, sound)
    // {
    //     
    // }

    public override string ProduceSound() => "Meow meow";
    
}