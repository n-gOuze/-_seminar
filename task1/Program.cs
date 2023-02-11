Console.WriteLine("Введите первое число ");
string answerA = Console.ReadLine();
int numberA = Convert.ToInt32(answerA);
Console.WriteLine("Введите второе число ");
string answerB = Console.ReadLine();
int numberB = Convert.ToInt32(answerB);
Console.WriteLine("Является ли первое число квадратом второго? ");
if (numberA == numberB * numberB)
{
    Console.WriteLine("Да ");
    }
else
{
  Console.WriteLine("Нет ");
}

