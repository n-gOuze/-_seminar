// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// и

// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

// Их произведение будет равно следующему массиву:

// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

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

int[,] ProductOfMatrix(int[,] firstmatrix, int[,] secondMatrix)
{
    int[,] myMatrix = new int[4, 4];
    for(int i = 0; i < myMatrix.GetLength(0); i++)
    {
        for(int j = 0; j < myMatrix.GetLength(1); j++)
        {
           myMatrix[i, j] = firstmatrix[i, j] * secondMatrix[i, j];
        }
    }
    return myMatrix;
}

int[,] firstMatrix = new int[4, 4];
int[,] secondMatrix = new int[4, 4];
CreateMatrix(firstMatrix);
PrintMatrix(firstMatrix);
Console.WriteLine();

CreateMatrix(secondMatrix);
PrintMatrix(secondMatrix);
Console.WriteLine();

int[,] productMatrix = ProductOfMatrix(firstMatrix, secondMatrix);
PrintMatrix(productMatrix);