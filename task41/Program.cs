// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int number = ReadNumber("Введите число");

int BinaryNumber(int number)
{
    int count = 0;
    int numberCopy = number;
    while (numberCopy != 0)
    {
        numberCopy = numberCopy / 2;
        count++;
    }
    return count;
}

int res = BinaryNumber(number);
Console.WriteLine(res);

int[] binaryArray = new int[res];

for(int i = 0; i < binaryArray.Length; i++)
{
    binaryArray[i] = number % 2;
    number /= 2;
}

Console.WriteLine(string.Join("", binaryArray));

void ReverseArray(int[] binaryArray)
{
    for (int i = 0; i < binaryArray.Length / 2; i++)
    {
        int temp = binaryArray[i];
        binaryArray[i] = binaryArray[binaryArray.Length - i - 1]; 
        binaryArray[binaryArray.Length - i - 1] = temp;
    }
}

ReverseArray(binaryArray);
Console.WriteLine(string.Join("", binaryArray));