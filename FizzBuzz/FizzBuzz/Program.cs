for (int i = 1; i <= 30; i++)
{
    if (i % 3 == 0 && i % 5 != 0)
    {
        Console.WriteLine("FIZZ");
    }
    else if (i % 3 != 0 && i % 5 == 0)
    {
        Console.WriteLine("BUZZ");
    }
    else if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("FIZZBUZZ");
    } else
    {
        Console.WriteLine(i);
    }
}
