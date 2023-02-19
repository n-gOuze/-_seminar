Console.WriteLine("Введите номер дня недели ");
int number = Convert.ToInt32(Console.ReadLine());
if(number == 6 || number == 7)
{
    Console.WriteLine("да ");
}
else
{
    Console.WriteLine("нет ");
}