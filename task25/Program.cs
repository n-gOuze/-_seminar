// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    return Convert.ToInt32(Console.ReadLine());
}

int CountOfDigits(int number)
{
    int count;
    for(count = 0; number !=0; count++)
    {
        number /= 10; //number = number / 10
    }
    return count;
}

int usernumber = ReadNumber("Введите значение");
int result = CountOfDigits(usernumber);
Console.WriteLine(result);