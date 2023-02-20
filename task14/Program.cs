Console.WriteLine("Введите трехзначное число ");
int number = Convert.ToInt32(Console.ReadLine());
if(number >= 100 && number < 1000)
{
    int firstDigit = number / 100;
    int secondDigit = (number - firstDigit*100) / 10;
    Console.WriteLine(secondDigit);
}
else
{
    Console.WriteLine("error");
}

// number = Math.Abs(number);
// int middle = (number / 10) % 10;
// Console.WriteLine(middle);