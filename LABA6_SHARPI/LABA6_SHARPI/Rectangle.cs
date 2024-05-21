namespace LABA6_SHARPI;

public sealed class Rectangle : GeometricShape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(string name, double width, double height)
        : base(name, width * height)
    {
        Width = width;
        Height = height;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Название: {Name}, Площадь: {Area}, Ширина: {Width}, Высота: {Height}");
    }

    public override void Draw()
    {
        Console.WriteLine("Рисуется прямоугольник.");
    }

    public void Draw(bool isFilled)
    {
        if (isFilled)
        {
            Console.WriteLine("Рисуется закрашенный прямоугольник.");
        }
        else
        {
            Console.WriteLine("Рисуется незакрашенный прямоугольник.");
        }
    }
}