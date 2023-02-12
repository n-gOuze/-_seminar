Console.WriteLine("Введите число N ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Целые числа в промежутке от -N до N ");
for(int i = -n; i <= n; i++)
{
    Console.WriteLine(i);
}