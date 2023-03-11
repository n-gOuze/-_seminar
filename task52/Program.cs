// Задача 52: Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6;

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

int Average (int[,] matrix)
{
    int sum = 0;
    int i = 0;
    int count = 1;
    int avg = 0;
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        sum = sum + matrix[i, j];
        count++;
    }
    avg = sum / count;
    return avg; 
}

int[,] matrix = new int[4, 5];
CreateMatrix(matrix);
PrintMatrix(matrix);
int result = Average(matrix);
Console.WriteLine(result);