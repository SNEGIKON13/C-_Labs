namespace LABA6_SHARPI;

public abstract class GeometricShape
{
    public string Name { get; set; }
    public double Area { get; private set; }

    protected double GetArea()
    {
        return Area;
    }

    protected void SetArea(double area)
    {
        if (area >= 0)
        {
            Area = area;
        }
    }

    public GeometricShape(string name, double area)
    {
        Name = name;
        if (area >= 0)
        {
            Area = area;
        }
    }

    public abstract void DisplayInfo();

    public virtual void Draw()
    {
        Console.WriteLine("Геометрическая фигура изображается.");
    }
}