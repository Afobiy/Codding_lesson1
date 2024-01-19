//Задача 2: Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
using System.Security.Cryptography;

int[] array = new int[10];
Random rnd = new Random();
int evenCounter = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(100);
    Console.WriteLine(array[i]);
}
Console.WriteLine("чётные числа в массиве:");
for(int j = 0;j < array.Length; j++)
{
    if(array[j] % 2 == 0)
    {
        Console.WriteLine(array[j]);
        evenCounter++;
    }
}
Console.WriteLine("Количество чётных чисел = " + evenCounter);









//for (int i = 0; i < array.Length; i++) тренировка запонения массив случайными числами
//{
//    array[i] = rnd.Next(1000);
//    Console.WriteLine(array[i]);
//}