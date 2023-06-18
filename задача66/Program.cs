/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/


using System;
using static System.Console;
Clear();
Write("Введите первое число: ");
int m = int.Parse(ReadLine());
Write("Введите второе число: ");
int n = int.Parse(ReadLine());

WriteLine($"Cумма чисел = {SumOfNumbers(m, n)}");

int SumOfNumbers(int a, int b)
{
    if (a == b) 
    return b;
    return (b + SumOfNumbers(a, b - 1));
}
