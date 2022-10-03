/*
Задача 27: Напишите программу, которая принимает 
на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int temp = 0;

while (userNumber > 0)
{
    temp = userNumber % 10;
    sum = sum + temp;
    userNumber = userNumber / 10;
}
Console.WriteLine($"Сумма цифр в числе {sum}");
