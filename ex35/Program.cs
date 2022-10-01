// **Задача 35:** Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
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

int minArray=10;
int maxArray=99;
ArrayFind(array, minArray, maxArray);










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

void ArrayFind(int[] array, int min, int max)
{
int count =0;
    for (int i = 0; i < array.Length; i++)
        if (array[i]> min-1&&array[i]<max+1)
        count++;
WriteLine($"количество элементов массивав промежутке от {min} до {max} равно {count}");
}