Console.WriteLine("Введите номер дня недели ");
int number = Convert.ToInt32(Console.ReadLine());
if(number == 6 || number == 7)
{
    Console.WriteLine("да ");
}
else if(number < 1 || number > 7)
{
    Console.WriteLine("число не является днем недели ");
}
else
{
    Console.WriteLine("нет ");
}