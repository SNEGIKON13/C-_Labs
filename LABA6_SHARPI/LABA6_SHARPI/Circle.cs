namespace LABA6_SHARPI;

public class Circle : GeometricShape
{
    public double Radius { get; set; }

    public Circle(string name, double area, double radius)
        : base(name, area)
    {
        Radius = radius;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Название: {Name}, Площадь: {Area}, Радиус: {Radius}");
    }

    public void Draw()
    {
        Console.WriteLine("Рисуется окружность.");
    }
}