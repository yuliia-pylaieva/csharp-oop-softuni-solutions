namespace BorderControl;

public class Pet : IEntity, ILivable
{
    public Pet(string name, string birthdate)
    {
        Name = name;
        Birthdate = birthdate;
    }

    public string Name { get; }
    public string Birthdate { get; }
}