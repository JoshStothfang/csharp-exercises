//calc sum
int[] nbrs = { 9, 1, 6, 9, 2, 4, 5, 3, 1, 3 };

/*
int sum = 0;

for (int i = 0; i < nbrs.Length; i++)
{
    sum += nbrs[i];
}

Console.WriteLine($"The sum is {sum}");


//solution with what we've learned so far
int index = 0;
int sum2 = nbrs[index] + nbrs[++index] + nbrs[++index] + nbrs[++index] + nbrs[++index] + nbrs[++index] + nbrs[++index] + nbrs[++index] + nbrs[++index] + nbrs[++index];

Console.WriteLine($"The sum is {sum2}");

//calc avg

double avg = (double)sum / nbrs.Length;

Console.WriteLine($"The average is {avg}");


//solution with what we've learned so far
Console.WriteLine($"Average is {sum / 10.0}");
*/
//sum and average of odd numbers squared

double sum3 = 0;
double avgCount = 0;

for (int i = 0; i < nbrs.Length; i++)
{
    if (nbrs[i] % 2 == 1)
    {
        sum3 += (Math.Pow(nbrs[i], 2));
        avgCount++;
    }
}

Console.WriteLine($"The sum is {sum3}");
Console.WriteLine($"The average is {sum3 / avgCount}");