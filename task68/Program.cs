// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int number = 8;
int stop = 1;

void Numbers (int n, int s)
{
    if (s > n) return;
    Numbers(n, s + 1);
    Console.Write($"{s}" + " ");
}

Numbers(number, stop);
