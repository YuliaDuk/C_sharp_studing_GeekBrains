﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число от 1 до 7");
int N = Convert.ToInt32(Console.ReadLine());
if(N<=5 && N>0)
{
    Console.WriteLine("будний день");
}
if(N==6 || N==7)
{
    Console.WriteLine("выходной день");
}
if(N<1 || N>7)
{
    Console.WriteLine("Вы ввели неверное число");
}