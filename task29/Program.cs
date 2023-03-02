// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

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

int usernumber = ReadNumber("Введите число");
int result = CountOfDigits(usernumber);
Console.WriteLine(result);