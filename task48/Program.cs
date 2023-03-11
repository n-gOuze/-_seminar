// Задача 49: Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть 
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

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

void FillMatrix (int[,] matrix)
{
    for(int i = 1; i < matrix.GetLength(0); i += 2)
    {
        for(int j = 1; j < matrix.GetLength(1); j +=2)
        {
            matrix[i, j] = matrix[i, j] * matrix[i, j];
        }
    }
}


int[,] myMatrix = new int[3, 4];
CreateMatrix(myMatrix);
PrintMatrix(myMatrix);
FillMatrix(myMatrix);
Console.WriteLine();
PrintMatrix(myMatrix);
