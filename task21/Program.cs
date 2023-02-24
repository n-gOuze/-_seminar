Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
int firstDigit = number / 10000;
int lastDigit = number % 10;
int secondDigit = (number - firstDigit*10000) / 1000;
int fourthDigit = (number % 100) / 10;
if(number < 999 || number > 100000)
{
    Console.WriteLine("Error");
}
else if(firstDigit == lastDigit || secondDigit == fourthDigit)
{
    Console.WriteLine("Число является полиндромом");
}
else
{
    Console.WriteLine("Число не является полиндромом");
}