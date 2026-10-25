namespace BindingDemo;

// ---------------- Q1 ----------------
public class Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Shape(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double Area() => Width * Height;

    public override string ToString() => $"(Width = {Width}, Height = {Height})";
}

// ---------------- Q2 ----------------
public class Cube : Shape
{
    public double Depth { get; set; }

    public Cube(double width, double height, double depth) : base(width, height)
    {
        Depth = depth;
    }

    public new double Area() => base.Area() * Depth;

    public void Print() =>
        Console.WriteLine($"Width = {Width}, Height = {Height}, Depth = {Depth}");
}
