﻿Console.WriteLine("Введите первое число ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число ");
int numberC = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Определим максимальное число ");

int max = numberA;

if(numberA > max) max = numberA;
if(numberB > max) max = numberB;
if(numberC > max) max = numberC;

Console.Write("max = ");
Console.WriteLine(max);
