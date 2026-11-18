using Cars.Models.Interfaces;

namespace Cars.Models;

public class Tesla : Car, IElectricCar
{
    public Tesla(string model, string color, int battery) : base(model, color)
    {
        Model = model;
        Color = color;
        Battery = battery;
    }

    public string Model { get; set; }
    public string Color { get; set; }
    public int Battery { get; set; }

    public override string ToString()
    {
        return $"{Color} {this.GetType().Name} {Model} with {Battery} Batteries";
    }
}