// Задача 39: Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

// const - определяет значения, которые в процессе нельзя изменять
// Пример:
// const double PI = 3.1416;

int[] GetRandomArray(int length, int leftRange, int rightRange)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(leftRange, rightRange + 1);
    }
    return array;
}

void ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++) //делим на 2, тк кол-во перестановок в 2 раза < длины массива
    {
        int temp = array[i];
        array[i] = array[array.Length - i - 1]; //меняем симметрично (первый с последним и тп)
        array[array.Length - i - 1] = temp;
    }
}

const int LENGTH = 6;
const int LEFBORDER = -10;
const int RIGHTBORDER = 10;

int[] myArray = GetRandomArray(LENGTH, LEFBORDER, RIGHTBORDER);
Console.WriteLine(string.Join(", ", myArray));
ReverseArray(myArray);
Console.WriteLine(string.Join(", ", myArray));
