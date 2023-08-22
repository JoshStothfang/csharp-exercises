int[] nbrs = {
   754, 233, 509, 792, 700, 596, 833, 658, 998, 742,
   187, 754, 308, 914, 489, 867, 717, 586, 929, 467,
   460, 241, 770, 324, 599, 259, 120, 800, 336, 609,
   690, 134, 598, 249, 282, 574, 334, 956, 659, 214,
   435, 643, 809, 874, 906, 620, 328, 369, 426, 561
};

int max = int.MinValue;
int min = int.MaxValue;
double sum = 0.0;

foreach(int i in nbrs)
{
    //find the min and max
    if(i > max)
    {
        max = i;
    }

    if(i < min)
    {
        min = i;
    }

    //sum
    sum += i;
}

//find the average
double avg = sum / nbrs.Length;

Console.WriteLine($"Min is {min}. Max is {max}. Avg is {avg}");

