// *Задача 37:** Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
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
int[] newArray;
newArray = PowArray(array);
WriteLine($"[{String.Join(",", newArray)}]");



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

int[] PowArray(int[] inArray)
{
    if (array.Length % 2 == 0)
    {
        newArray = new int[array.Length / 2];
    }
    else
    {
        newArray = new int[array.Length / 2 + 1];
        newArray[newArray.Length - 1] = array[array.Length / 2];
    }
    for (int i = 0; i < inArray.Length / 2; i++)
    {
        newArray[i] = inArray[i] * inArray[inArray.Length - 1 - i];
    }

    return newArray;
}
