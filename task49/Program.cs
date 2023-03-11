// Задача 51: Задайте двумерный массив. 
// Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

void CreateMatrix (int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintMatrix (int[,] matrix)
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

int SumMatrix (int[,] matrix)
{
    int sum = 0;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        {
            sum = sum + matrix[i, i];
        }
    }
    return sum;
}

int[,] myMatrix = new int[3, 4];
CreateMatrix(myMatrix);
PrintMatrix(myMatrix);
int res = SumMatrix(myMatrix);
Console.WriteLine($"Сумма элементов главной диагонали равна {res}");
