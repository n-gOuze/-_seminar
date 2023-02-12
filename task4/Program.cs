Console.WriteLine("Введите трехзначное число ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Определим последнюю цифру этого числа ");
int result = number % 10;
Console.WriteLine(result);
