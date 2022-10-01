// Напишите программу замены элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
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

int [] array1=ArrayDif(array);
WriteLine($"[{String.Join(",", array1)}]");











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

int[] ArrayDif(int [] array)
{
    
    for(int i=0;i<array.Length;i++)
    {
        array[i]=-array[i];
    }
    return array;
}