// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
using static System.Console;
Clear();
WriteLine("Введите размер массива: ");
int length = int.Parse(ReadLine()!);
int[] array = GetArray(length, 100, 1000);
WriteLine($"[{String.Join(",", array)}]");
ArrayFind(array);


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
void ArrayFind(int[] array)
{
int count =0;
    for (int i = 0; i < array.Length; i++)
        if (array[i]%2==0)
        count++;
WriteLine($"количество четных элементов массива равно {count}");
}