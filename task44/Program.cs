// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] CreateArray(int length)
{
    int[] array = new int[length];

    for (int M = 0; M < array.Length; M++)
    {
        array[M] = ReadNumber($"Введите число M");
    }

    return array;
}

int PositiveNumbers(int[] array)
{
    int count = 0; //количество положительных элементов

    for(int i = 0; i < array.Length; i++) 
    {
        if (array[i] > 0)
        {
            count++;
        }
    }

    return count;
}

int number = ReadNumber("Введите количество чисел M"); //длина нашего массива
int[] myArray = CreateArray(number); //получаем массив на count элементов
int result = PositiveNumbers(myArray); //получаем количество положительных переменных
Console.WriteLine($"Было введено {result} положительных элемента(-ов)");


// задача от преподавателя)
// Пользователь вводит с клавиатуры неопределенное количество чисел (while (true)). 
// Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Ввод чисел останавливается при помощи ввода слова "stop"