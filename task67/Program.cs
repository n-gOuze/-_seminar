//  Напечатать двоичное представление числа 13

int number = 13;

void PrintBinaryView (int n)
{
    if (n == 0) return;
    PrintBinaryView(n/ 2);
    Console.Write(n % 2);
}

PrintBinaryView(number);


