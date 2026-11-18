namespace Cars.Models;

public class Seat : Car
{
    public Seat(string model, string color) : base(model, color)
    {
        Model = model;
        Color = color;
    }

    public string Model { get; set; }
    public string Color { get; set; }

    public override string ToString()
    {
        return $"{Color} {this.GetType().Name} {Model}";
    }
}