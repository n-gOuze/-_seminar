// Console.WriteLine("Введите координату x первой точки");
// double xa = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите координату y первой точки");
// double ya = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите координату x второй точки");
// double xb = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите координату y второй точки");
// double yb = Convert.ToDouble(Console.ReadLine());
// double res = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2));
// Console.WriteLine(res);

double ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    double value = double.Parse(Console.ReadLine());
    return value;
}

double xa = ReadNumber("Введите координату x первой точки");
double ya = ReadNumber("Введите координату y первой точки");
double xb = ReadNumber("Введите координату y второй точки");
double yb = ReadNumber("Введите координату y второй точки");

double res = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2));
Console.WriteLine($"{res:f2}"); // чтобы округлить значение, f2 - число знаков после запятой