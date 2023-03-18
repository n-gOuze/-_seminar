// Задача 67: Напишите программу, которая будет принимать на вход число 
// и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int number = 453;

int Sum (int n)
{
    if (n == 0) return 0;
    int result = n % 10 + Sum(n / 10);
    return result;
}

Console.WriteLine(Sum(number));