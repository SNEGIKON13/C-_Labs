namespace LABA7_SHARPI;

public class Complex
{
    private double real;
    private double imaginary;

    public double Real
    {
        get => real;
        set => real = value;
    }

    public double Imaginary
    {
        get => imaginary;
        set => imaginary = value;
    }

    public Complex(double real = 0, double imaginary = 0)
    {
        Real = real;
        Imaginary = imaginary;
    }

    public override string ToString()
    {
        return $"{Real} + {Imaginary}i";
    }

    public double Modulus()
    {
        return Math.Sqrt(Real * Real + Imaginary * Imaginary);
    }

    public static Complex operator +(Complex c1, Complex c2)
    {
        return new Complex(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
    }

    public static Complex operator -(Complex c1, Complex c2)
    {
        return new Complex(c1.Real - c2.Real, c1.Imaginary - c2.Imaginary);
    }

    public static Complex operator *(Complex c1, Complex c2)
    {
        return new Complex(c1.Real * c2.Real - c1.Imaginary * c2.Imaginary, c1.Real * c2.Imaginary + c1.Imaginary * c2.Real);
    }

    public static Complex operator /(Complex c1, Complex c2)
    {
        double denom = c2.Real * c2.Real + c2.Imaginary * c2.Imaginary;
        return new Complex((c1.Real * c2.Real + c1.Imaginary * c2.Imaginary) / denom, (c1.Imaginary * c2.Real - c1.Real * c2.Imaginary) / denom);
    }

    public static Complex operator +(Complex c, double d)
    {
        return new Complex(c.Real + d, c.Imaginary);
    }

    public static Complex operator -(Complex c, double d)
    {
        return new Complex(c.Real - d, c.Imaginary);
    }

    public static Complex operator *(Complex c, double d)
    {
        return new Complex(c.Real * d, c.Imaginary * d);
    }

    public static Complex operator /(Complex c, double d)
    {
        return new Complex(c.Real / d, c.Imaginary / d);
    }

    public static bool operator >(Complex c1, Complex c2)
    {
        return c1.Modulus() > c2.Modulus();
    }

    public static bool operator <(Complex c1, Complex c2)
    {
        return c1.Modulus() < c2.Modulus();
    }

    public static bool operator ==(Complex c1, Complex c2)
    {
        return c1.Modulus() == c2.Modulus();
    }

    public static bool operator !=(Complex c1, Complex c2)
    {
        return c1.Modulus() != c2.Modulus();
    }

    public static Complex operator ++(Complex c)
    {
        return new Complex(c.Real + 1, c.Imaginary);
    }

    public static Complex operator --(Complex c)
    {
        return new Complex(c.Real - 1, c.Imaginary);
    }

    public static explicit operator double(Complex c)
    {
        return c.Modulus();
    }

    public static implicit operator Complex(double d)
    {
        return new Complex(d, 0);
    }

    public static implicit operator bool(Complex c)
    {
        return c.Real != 0 || c.Imaginary != 0;
    }

    public double this[int index]
    {
        get
        {
            if (index == 0)
            {
                return Real;
            }
            else if (index == 1)
            {
                return Imaginary;
            }
            else
            {
                throw new IndexOutOfRangeException("Invalid index");
            }
        }
        set
        {
            if (index == 0)
            {
                Real = value;
            }
            else if (index == 1)
            {
                Imaginary = value;
            }
            else
            {
                throw new IndexOutOfRangeException("Invalid index");
            }
        }
    }
}