﻿/* Задача 25: Напишите цикл, который принимает на вход два
числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */
Console.WriteLine("Введите число А: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
int result = 1;

while (B > 0)
{
    result = result * A;
    B = B - 1;
}

 Console.WriteLine($"Число А в степени В равно {result}");
