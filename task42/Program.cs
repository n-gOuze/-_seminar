// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int N = ReadNumber("Введите число N");

int[] Fibonacci = new int[N];

Fibonacci[0] = 0;
Fibonacci[1] = 1;

{
    for(int i = 2; i < Fibonacci.Length; i++)
    {
        Fibonacci[i] = Fibonacci[i - 1] + Fibonacci[i - 2];
    }
}

Console.WriteLine(string.Join("", Fibonacci));