int[] arr = { 1, 2, 3, 4, 5, 6, 7};
int i = 0;

void ReverseArray(int[] arr)
{
    if (i < arr.Length - arr.Length / 2)
    {
        int dump = arr[i];
        arr[i] = arr[arr.Length - 1 - i];
        arr[arr.Length - 1 - i] = dump;
        i++;
        ReverseArray(arr);
    }
}



ReverseArray(arr);
for (i = 0; i <= arr.Length - 1; i++)
{
    Console.Write(arr[i] + " ");
}