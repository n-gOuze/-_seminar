﻿// Задача 52: Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3,0.

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

double Average (int[,] matrix)
{
    double sum = 0;
    int j = 0;
    int count = 0;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        sum = sum + matrix[i, j];
        count++;
    }
    double avg = sum / count;
    return avg;
}

int[,] matrix = new int[3, 4];
CreateMatrix(matrix);
PrintMatrix(matrix);
double result = Average(matrix);
Console.WriteLine(result);