// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

void CreateMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void SumOfElements (int[,] matrix)
{
    int[] count = new int[matrix.GetLength(0)];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        int index = i;
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
        }
        count[index] = sum;
        Console.WriteLine($"{sum}");
    }

    int min = count[0];
    int str = 1;

    for(int index = 0; index < count.Length; index++)
    {
        if(count[index] < min)
        {
            str = index + 1;
            Console.WriteLine($"Строка номер {str}");
            break;           
        }
        else if(count[index] > min)
        {
            Console.WriteLine("Строка номер 1");
            break;
        }
    }
}

int[,] matrix = new int[3, 4];
CreateMatrix(matrix);
PrintMatrix(matrix);
SumOfElements(matrix);

