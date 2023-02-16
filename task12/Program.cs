Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int resultA = number % 7; 
int resultB = number % 23;
if(resultA == 0)
{
    if(resultB == 0)
    {
        Console.WriteLine("да ");
    }
}
else if(resultB == 0)
{
    {
        Console.WriteLine("нет ");
    }
}
else
{
    Console.WriteLine("нет ");
}
