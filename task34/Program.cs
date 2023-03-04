// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

void NewArray(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 1000);
    }
}

int SumOfNumbers (int [] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        while (array[i] >= array[10] && array[i] <= array[99])
        {
            result = i++;
        }
    }
return result;
}


int[] array = new int[123];
NewArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");

int res = SumOfNumbers(result);
Console.WriteLine(res);

