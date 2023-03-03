// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int a = ReadNumber("Введите число А");
int b = ReadNumber("Введите число B");

// double res = Math.Pow(a, b);

int CountOfA(int a, int b)
{
    int result = 1;
    for(int i = 0; i < b; i++)
    {
        result = result * a;
    }
    return result;
}

int power = CountOfA(a, b);
Console.WriteLine(power);