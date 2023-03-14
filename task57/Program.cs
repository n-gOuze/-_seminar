// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.

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
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int min = matrix[i, j];
            for( int count = 0; count < matrix.GetLength(1); count++)
            {
                if (matrix[i, count] < min) min = matrix[i, count];
                int temp = matrix[i, count];
                matrix[i, count] = min;
                min = temp;  
            }         
        }      
    }
}          

int[,] matrix = new int[4, 4];
FillMatrix(matrix);
PrintMatrix(matrix);
MinMaxMatrix(matrix);
Console.WriteLine();
PrintMatrix(matrix);