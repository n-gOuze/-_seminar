// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

void FillMatrix (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintMatrix (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void MinMaxMatrix (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0) - 1; i++)
    {
        if(matrix[i, j] < matrix[i + 1, j + 1])
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[i + 1, j + 1];
            matrix[i + 1, j + 1] = temp;            
        }           
    }
}

int[,] matrix = new int[3, 4];
FillMatrix(matrix);
PrintMatrix(matrix);
MinMaxMatrix(matrix);
Console.WriteLine();
PrintMatrix(matrix);