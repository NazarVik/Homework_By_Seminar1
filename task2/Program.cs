﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();
Console.Write("input number1 = ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("input number2 = ");
int number2 = int.Parse(Console.ReadLine());

Console.Write("input number3 = ");
int number3 = int.Parse(Console.ReadLine());

int max = number1;

if (number2 > max) max = number2;
if (number3 > max) Console.WriteLine(number3);
else Console.WriteLine(max);