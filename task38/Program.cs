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
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > Max) Max = array[i];
        else if(array[i] < Min) Min = array[i];
        sum = Max + Min;
    }
    return sum;
}

int[] array = new int[5];
FillArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
int res = MaxMinNum(array);
Console.WriteLine(res);

