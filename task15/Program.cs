Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Определим третью цифру этого числа ");
if(number < 100)
{
    Console.WriteLine("третьей цифры нет ");
}
else
{
    while(number > 999)
    {
        int count = number / 10;
    }
    int result = number % 10;
    Console.WriteLine(result);
}