namespace LABA6_SHARPI

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle("Окружность", 3.14, 5.0);
            circle.DisplayInfo();
            circle.Draw();

            Console.WriteLine();

            Rectangle rectangle = new Rectangle("Прямоугольник", 10.0, 5.0);
            rectangle.DisplayInfo();
            rectangle.Draw();
            rectangle.Draw(true);

            Console.ReadLine();
        }
    }
}