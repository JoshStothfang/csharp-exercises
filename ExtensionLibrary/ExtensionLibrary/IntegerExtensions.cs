using System;
namespace ExtensionLibrary;

public static class IntegerExtensions
{
    public static int Func(this int i)
    {
        return (i * i) + (3 * i) + 5;
    }

    public static void WriteLine(this int i)
    {
        Console.WriteLine(i);
    }
}

