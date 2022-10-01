// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
using static System.Console;
Clear();
WriteLine("Введите размер массива: ");
int length = int.Parse(ReadLine()!);
WriteLine("Введите мин значение массива: ");
int min = int.Parse(ReadLine()!);
WriteLine("Введите макс значение массива: ");
int max = int.Parse(ReadLine()!);
int[] array = GetArray(length, min, max);
WriteLine($"[{String.Join(",", array)}]");
WriteLine("Введите искомое число: ");
int find = int.Parse(ReadLine()!);
ArrayFind(array, find);











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

void ArrayFind(int[] array, int find)
{

    for (int i = 0; i < array.Length; i++)
        if (array[i] == find)
            WriteLine($"элемент {i} массива равен {find}");
}
    
