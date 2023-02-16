int number = Random.Shared.Next(10, 100);
Console.WriteLine(number);
int lastDigit = number % 10;
//Console.WriteLine(lastDigit);
int firstDigit = number / 10;
//Console.WriteLine(firstDigit);
if(firstDigit > lastDigit)
{
   // Console.WriteLine("max");
   // Console.WriteLine(firstDigit);
   // Console.WriteLine("min");
   // Console.WriteLine(lastDigit);
   // Console.WriteLine("max" + firstDigit + "min" + lastDigit);
   Console.WriteLine($"max {firstDigit}, min {lastDigit}");
}
else
{
   // Console.WriteLine(lastDigit);
   Console.WriteLine($"max {lastDigit}, min {firstDigit}");
}