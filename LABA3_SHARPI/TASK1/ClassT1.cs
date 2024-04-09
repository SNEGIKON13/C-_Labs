namespace TASK1
{
    public class ClassT1
    {
        static double Min(double x, double y)
        {
            return x<= y ? x : y;
        }
        public static double FindZ(double x, double y)
        {
            return Min(x, 2 * y + x) - Min(7 * x + 2 * y, y);
        }
    }
}