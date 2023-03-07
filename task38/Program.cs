// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void FillArray(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 20);
    }
}

int MaxMinNum(int[] array)
{
    int Max = array[0];
    int Min = array[0];
    int dif = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > Max) Max = array[i];
        else if(array[i] < Min) Min = array[i];
        dif = Max - Min;
    }
    return dif;
}

int[] array = new int[5];
FillArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
int res = MaxMinNum(array);
Console.WriteLine(res);

// Для вывода числа Double
// int numberInt = Random.Shared.Next(1, 10);
// double numberDouble = Random.Shared.NextDouble(); // [0.0, 1.0)
// double numberDouble = Random.Shared.NextDouble() * 10; // [0.0, 10.0)
// double numberDouble = Random.Shared.NextDouble() * 100 - 20; // [-20.0, 80.0)
// Console.WriteLine($"{numberDouble:f2}); //чтобы показать определенное количество знаков после , (2)

// Для вывода массива с числами Double
// double[] array = new double[] {2.35345345, 1.392391392, 234.23423};
// Console.WriteLine($"{string.Join(", ", array.Select(x => Math.Round(x, 2)))}");
