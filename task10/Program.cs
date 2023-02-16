int number = Random.Shared.Next(100, 1000);
Console.WriteLine(number);
int lastDigit = number % 10;
int firstDigit = number / 100;
// Console.WriteLine($"{firstDigit}{lastDigit}");
int result = firstDigit*10 + lastDigit;
Console.WriteLine(result);