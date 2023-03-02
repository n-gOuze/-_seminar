// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    return Convert.ToInt32(Console.ReadLine());
}

int SumOfDigits(int number)
{
    int result = 0;
    while (number > 0)
    {
        result = result + number % 10;
        number = number / 10;
    }
    return result;
}

int number = ReadNumber("Введите число");
int result = SumOfDigits(number);
Console.WriteLine(result);