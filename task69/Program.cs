// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int numberM = 4;
int numberN = 8;

int Sum (int m, int n)
{
    if (n < m) return 0;
    int result = n + Sum(m, n - 1);
    return result;
}

Console.WriteLine(Sum (numberM, numberN));
