Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Является ли число четным? ");

int result = number % 2;
if(result == 0)
{
    Console.WriteLine("Да ");
}
else
{
    Console.WriteLine("Нет ");
}


