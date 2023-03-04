// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
// второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

void FillArray(int[] newArray)
{
    int length = newArray.Length;
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = new Random().Next(0, 10);
    }
}

int[] LengthArray(int[] array)
{
    if(array.Length % 2 == 0)
    {
        return new int[array.Length / 2];
    }
    else
    {
        return new int[array.Length / 2 + 1];
    }
}

int[] MultiplyArray(int[] array)
{
    int[] result = LengthArray(array);
    for (int i = 0; i < array.Length / 2; i++)
    {
        result[i] = array[i] * array[array.Length - i - 1];
    }
    if (array.Length % 2 != 0)
    {
        result[result.Length - 1] = array[array.Length / 2];
    }
    return result;
}

int[] newArray = new int[5];
FillArray(newArray);
Console.WriteLine($"{string.Join(',', newArray)} -> {string.Join(',', MultiplyArray(newArray))}");