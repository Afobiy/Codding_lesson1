// Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)

int[] array = { 1, 3, 5, 6, 7, 8 };
int i = 0;
int iNeg = array.Length - 1;
int iNegInMemory = 0;
int iInMemory = 0;
while (i < array.Length)
{
    if (iNeg > i)
    {
        iInMemory = array[i];
        iNegInMemory = array[iNeg];
        array[i] = iNegInMemory;
        array[iNeg] = iInMemory;
        Console.WriteLine(array[i]);
        i++;
        iNeg--;
    }
    else
    {
        Console.WriteLine(array[i]);
        i++;
        iNeg--;
    }
}
