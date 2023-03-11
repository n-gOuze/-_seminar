// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int ReadNumber(string message)
{
    Console.WriteLine(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

void CreateMatrix(double[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.NextDouble() * 10;
        }
    }
}

void PrintMatrix(double[,] matrix)
{
        for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]:f1}" + " ");
        }
        Console.WriteLine();
    }
}

int m = ReadNumber("Введите количество строк");
int n = ReadNumber("Введите количество столбцов");
double[,] matrix = new double[m, n];
CreateMatrix(matrix);
PrintMatrix(matrix);