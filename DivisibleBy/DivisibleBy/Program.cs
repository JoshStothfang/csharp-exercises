int sum = 0;

for (int i = 1; i <= 50; i++)
{
    if (i % 5 == 0 || i % 7 == 0)
    {
        sum += i;
    }
}

//Alternate
/*
for(int i = 1; i <= 50; i++)
{
    if(!(i % 5 == 0 || i % 7 == 0))
    {
        continue;
    }

    sum += i;
}
*/

Console.WriteLine($"The sum is {sum}");

