int[] array = {10, 10, 10, 2, 4, 1, 9, 4, 8, 50};
int min = 20;
int max = 90;
int i = 0;
int j = 0;
while (i < array.Length)
{
    if (array[i] > min & array[i] < max)
    {
        Console.WriteLine(array[i]);
        j = j + 1;
        i = i + 1;
    }
    else
    {
    i = i + 1;
    }
}
Console.WriteLine(j);