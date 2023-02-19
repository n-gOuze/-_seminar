Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Определим третью цифру этого числа ");
if(number < 100)
{
    Console.WriteLine("третьей цифры нет ");
}
else
{
    int count = number;
    while (count > 999)
    {
        count = count / 10;
    }
    int result = count % 10;
    Console.WriteLine(result);
}