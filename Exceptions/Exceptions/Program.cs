using Exceptions;

//exception occured in method4 but bubbles up to try catch in method2
method1();

void method1()
{
    try
    {
        method2();
    }
    catch
    {
        Console.WriteLine("Caught");
    }
}
void method2()
{
    method3();
}
void method3()
{
    method4();
}
void method4()
{
    var d = 0;
    var e = 1 / d;
}


/* //try,catch,finally
int n = 1;
int d = 0;

try
{
    throw new Exception("WHY?");
    var a = n / d;
}
catch (DivideByZeroException)
{
    Console.WriteLine("Don't divide by zero!");
}
catch (Exception)
{
    Console.WriteLine("This is a general exception!");
}
finally
{
    Console.WriteLine("This will always be executed!");
}

Console.WriteLine("Done...");
*/
/*
if (d ==0)
{
    var bcex = new BootcampException($"Dividing by zero is a NO NO!");
    bcex.Numerator = n;
    bcex.Denominator = d;
    throw bcex;
}
*/
