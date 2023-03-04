// Задача 32: Напишите программу замена элементов массива: положительные элементы замените 
// на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] GetArray(int[] array)
{
    int length = array.Length;
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 11);
    }
return array;
}

void ReplaceArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * (-1);
    }
}

int[] array = new int[10];
int[] myArray = GetArray(array);
Console.WriteLine($"[{string.Join(", ", myArray)}]");
ReplaceArray(myArray);
Console.WriteLine($"[{string.Join(", ", myArray)}]");

