// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}

int ProductToA(int a)
{
    int product = 1;
    for(int i = 1; i <= a; i++)
    {
        product = product * i;
    }
    return product;
}

int number = ReadNumber("Введите число А");
int result = ProductToA(number);
Console.WriteLine(result);