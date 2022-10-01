// **Задача 31:** Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
//  Найдите сумму отрицательных и положительных элементов массива.// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма 
// положительных чисел равна 29, сумма отрицательных равна -20.
using static System.Console;
Clear();
WriteLine("Введите размер массива: ");
int length = int.Parse(ReadLine()!);
WriteLine("Введите мин значение массива: ");
int min = int.Parse(ReadLine()!);
WriteLine("Введите макс значение массива: ");
int max = int.Parse(ReadLine()!);
int[] array = GetArray(length, min, max);
// string strArray=String.Join(",", array);
WriteLine($"[{String.Join(",", array)}]");

int positiveSum = 0;
int negativeSum = 0;

foreach (int element in array)
{
    positiveSum += element > 0 ? element : 0;
    negativeSum += element < 0 ? element : 0;

    // if (element > 0)
    // {
    //     positiveSum = positiveSum + element;
    // }
    //  if (element < 0)
    // {
    //     negativeSum = negativeSum + element;
    // }
}
WriteLine($"сумма отрицательных элементов={negativeSum}, сумма положительных элементов ={positiveSum}");







int[] GetArray(int size, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(minValue, maxValue + 1);
    }
    return result;
}