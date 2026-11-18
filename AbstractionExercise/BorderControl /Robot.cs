namespace BorderControl;

public class Robot : IEntity, IIdentifiable
{
    public Robot(string model, string id)
    {
        Id = id;
        Model = model;
    }

    public string Model { get; }
    public string Id { get; }
}