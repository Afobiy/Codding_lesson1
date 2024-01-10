int n = 10;
int[] array = {1, 5, 89, 45, 15, 98, 82, 6, 78, 75};

int i = 0;
while(i < n)
{
    if(array[i] % 2 == 0)
    {
    Console.Write($"{array[i]} ");
    }
    i = i + 1;
}