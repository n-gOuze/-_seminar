Console.WriteLine("Введите число N ");
int n = Convert.ToInt32(Console.ReadLine());
for(int i = -n; i <= n; i++)
{
    int result = i % 2;
    if(result == 0)
    {
        Console.WriteLine(i);
    }
}
