int[] array = {2, 5, 2, 3, 6, 3, 7, 8, 2, 4};
int i = 0;
int j = 0;
while (i < array.Length)
{
    if(array[i] % 2 == 0)
    {
        j = j + 1;
        i = i + 1;
    }
    else
    {
        i = i + 1;
    }
}
Console.WriteLine(j);