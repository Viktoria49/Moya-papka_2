﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//  и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру: ");
int number = int.Parse(Console.ReadLine());

if (number > 0 && number < 8)
if (number > 5 && number < 8)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
else

    Console.WriteLine("Некорректный ввод");


