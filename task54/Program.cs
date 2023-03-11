// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 

int ReadNumber(string message)
{
    Console.WriteLine(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[,] GetRandomMatrix(int rows, int columns, int leftBorder = 0, int rightBorder = 10)
{
    int[,] matrix = new int[rows, columns];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(leftBorder, rightBorder + 1);
        }
    }
    return matrix;
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

int[,] TransposeMatrix(int[,] sourceMatrix)
{
    int[,] newMatrix = new int[sourceMatrix.GetLength(1), sourceMatrix.GetLength(0)]; //поменяли 0 на 1 и 1 на 0, чтобы заменить строки на столбцы и наоборот

    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            newMatrix[i, j] = sourceMatrix[j, i];
        }
    }
    return newMatrix;
}

int m = ReadNumber("Введите количество строк");
int n = ReadNumber("Введите количество столбцов");
int[,] myMatrix = GetRandomMatrix(m, n);
PrintMatrix(myMatrix);
int[,] myTransposeMatrix = TransposeMatrix(myMatrix);
Console.WriteLine();
PrintMatrix(myTransposeMatrix);

