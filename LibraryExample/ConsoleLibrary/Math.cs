namespace ConsoleLibrary;

public class Math
{
    public static int Add(int x, int y)
    {
        return x + y;
    }

    public static int Sub(int x, int y)
    {
        return x - y;
    }

    public static int Mult(int x, int y)
    {
        return x * y;
    }

    public static int Div(int x, int y)
    {
        return x / y;
    }

    public static double Inverse(double a)
    {
        return 1 / a;
    }

    public static int Modulo(int a, int b)
    {
        var isZero = (b * (a / b));
        if (isZero == 0)
        {
            return 0;
        }
        else
        {
            return a - (b * (a / b));
        }
    }

    public static long Cubed(int a)
    {
        return a * a * a;
    }

    public static long Power(int x, int y)
    {
        var pow = 1;

        for (int i = 1; i <= y; i++)
        {
            pow *= x;
        }

        return pow;
        
    }
}

