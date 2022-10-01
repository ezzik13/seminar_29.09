// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
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

SumArray(array);




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

void SumArray(int[] inArray)
{
    int sum = 0;
    for (int i = 1; i < inArray.Length; i++)
    {
        
        if (i % 2 == 1)
            sum = sum + inArray[i];

    }
    WriteLine($"Сумма нечетных элементов массива равна {sum}");
}