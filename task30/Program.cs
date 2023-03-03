// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// Сделала для чисел от 1 до 99, чтобы было читабельно

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(0, 100);
        index++;
    }
}

int[] array = new int[8];
FillArray(array);
Console.WriteLine($"[{string.Join(",", array)}]");

// void PrintArray(int[] collection)
// {
//     int length = collection.Length;
//     int index = 0;
//     while (index < length)
//     {
//         Console.WriteLine(collection[index]);
//         index++;
//     }
// }

// int[] array = new int[8];

// FillArray(array);
// PrintArray(array);
