// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
using static System.Console;
Clear();
WriteLine("Введите размер массива: ");
int length = int.Parse(ReadLine()!);

double[] array = new double[length];
FillArrayRandomNumbers(array);
WriteLine($"[{String.Join("   ", array)}]");
DiffMaxMinArray(array);


void FillArrayRandomNumbers(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToDouble(new Random().Next(1, 100) / 10.0);
    }
}


void DiffMaxMinArray(double[] array)
{
double max = array[0];
double min = array[0];

for (int i = 1; i < array.Length; i++)
{
    if (array[i] > max) max = array[i];    
    else 
    if (array[i] < min)  min = array[i];
     
}

double result = max - min;
Console.WriteLine($"Разница между максимальным {max} и минимальным {min} элементами: {result}");
}