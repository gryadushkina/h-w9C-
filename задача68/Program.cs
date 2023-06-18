/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

using System;
using static System.Console;
Clear();
Write("Введите первое число: ");
int a = int.Parse(ReadLine());
Write("Введите второе число: ");
int b = int.Parse(ReadLine());

WriteLine($"Функция Аккермана = {Akkerman(a, b)}");

int Akkerman(int c, int d)
{
    if (c == 0) return d + 1;
    if (d == 0) return Akkerman(c - 1, 1);
    return Akkerman(c - 1, Akkerman(c, d - 1));
}