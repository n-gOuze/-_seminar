// Console.WriteLine("Введите координаты точки по X");
// int x = Convert.ToInt32(Console.ReadLine());

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int x = ReadNumber("Введите координаты точки по X");
int y = ReadNumber("Введите координаты точки по Y");

// Console.WriteLine("Введите координаты точки по Y");
// int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(
    x > 0 && y > 0 ? "Точка находится в первой координатной четверти":
    x < 0 && y > 0 ? "Точка находится во второй координатной четверти":
    x < 0 && y < 0 ? "Точка находится в третьей координатной четверти":
    x > 0 && y < 0 ? "Точка находится в четвертой координатной четверти":
    "Невозможно определить координатную четверть"
);

// if(x > 0 && y > 0)
// {
//     Console.WriteLine("Точка находится в первой координатной четверти");
// }
// else if(x < 0 && y > 0)
// {
//     Console.WriteLine("Точка находится во второй координатной четверти");
// }
// else if(x < 0 && y < 0)
// {
//     Console.WriteLine("Точка находится в третьей координатной четверти");
// }
// else if(x > 0 && y < 0)
// {
//     Console.WriteLine("Точка находится в четвертой координатной четверти");
// }
// else
// {
//     Console.WriteLine("Невозможно определить координатную четверть");
// }