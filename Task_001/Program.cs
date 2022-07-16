﻿// Задача N1, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число, чтобы проверить, является ли оно палиндромом: ");

int numberA = int.Parse(Console.ReadLine()!);

if (numberA / 10000 == numberA % 10 && numberA / 1000 % 10 == numberA / 10 % 10)
{
    Console.WriteLine("Данное число является палиндромом");
}
else
{
    Console.WriteLine("Данное число не является палиндромом");
}