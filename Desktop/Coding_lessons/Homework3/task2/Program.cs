//Задача 2: Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateRandomArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length]; 
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue);
        //Console.Write($"{array[i]} ");
    }
    return array;
}


int[] array = CreateRandomArray(10, 0, 1000);
//int[] result = CreateRandomArray(10, 0, 1000);

Console.WriteLine("Чётные числа в массиве:");
int CountEvenNumbers()
{
    int evenCounter = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        Console.WriteLine(array[i]);
        evenCounter++;
    }
}
return evenCounter;
}

Console.WriteLine("Количество чётных чисел");
int result = CountEvenNumbers();
Console.WriteLine(result);










//for (int i = 0; i < array.Length; i++) тренировка запонения массив случайными числами
//{
//    array[i] = rnd.Next(1000);
//    Console.WriteLine(array[i]);
//}