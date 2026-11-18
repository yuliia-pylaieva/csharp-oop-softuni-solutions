namespace ClassBoxData;

public class Box
{
    public Box(double length, double width, double height)
    {
        if (length <= 0)
        {
            throw new ArgumentException($"{nameof(Length)} cannot be zero or negative.");
        }

        if (width <= 0)
        {
            throw new ArgumentException($"{nameof(Width)} cannot be zero or negative.");
        }

        if (height <= 0)
        {
            throw new ArgumentException($"{nameof(Height)} cannot be zero or negative.");
        }

        this.Height = height;
        this.Width = width;
        this.Length = length;
    }

    public double Height { get; }
    public double Width { get; }
    public double Length { get; }

    public double SurfaceArea() => this.LateralSurfaceArea() + 2 * this.Length * this.Width;

    public double Volume() => this.Length * this.Width * this.Height;

    public double LateralSurfaceArea() => 2 * (this.Length * this.Height + this.Width * this.Height);
}