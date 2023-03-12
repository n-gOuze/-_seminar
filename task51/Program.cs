// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int ReadNumber(string message)
{
    Console.WriteLine(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int m = ReadNumber("Введите индекс по номеру строки");
int n = ReadNumber("Введите индекс по номеру столбца");

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

void CheckNumber (int[,] matrix)
{
    int res = 0;
    if (m < matrix.GetLength(0) && n < matrix.GetLength(1))
    {
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                res = matrix[m, n];
            }
        }
        Console.WriteLine($"{res}");    
    }

    else
    {
        Console.WriteLine("Значение не найдено");
    }
}

int[,] matrix = new int[4, 5];
CreateMatrix(matrix);
PrintMatrix(matrix);
CheckNumber(matrix);

