// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void CreateArray(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
}

bool CheckNumber(int[] array, int number)
{
    bool result = false;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == number)
        {
            result = true;
            break;
        }
    }
    return result;
}

int[] array = new int[5];
CreateArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");

int number = ReadNumber("Введите число");

bool res = CheckNumber(array, number);
Console.WriteLine(res);
