Console.WriteLine("Введите первое число ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int numberB = Convert.ToInt32(Console.ReadLine());
int result = numberB % numberA;
if(result == 0)
{
    Console.WriteLine("Кратно ");
}
else
{
    Console.WriteLine($"Не кратно, остаток {result}");
}
