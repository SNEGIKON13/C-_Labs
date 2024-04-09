namespace TASK2.services;

public class ClassT2
{
    public static int FindMethod(double z)
    {
        return z < -1 ? 1 : 2;
    }
    static double FindX(double z)
    {
        if (FindMethod(z) == 1)
        {
            return -z / 3;
        }
        else
        {
            return z >= 0 ? z : -z;
        }
    }
    public static double FindY(double z)
    {
        double x = FindX(z);
        return Math.Log(x + 0.5) + Math.Exp(x) - Math.Exp(-x);
    }
}