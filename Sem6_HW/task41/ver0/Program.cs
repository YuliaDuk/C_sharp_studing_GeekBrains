﻿// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите числа через запятую: ");
string text = Console.ReadLine();
int[] numbers = Array.ConvertAll(text.Split(','), int.Parse);
int count =0;
for (int i = 0; i < numbers.Length; i++)
{
    if( numbers[i]>0)
    {
        count++;
    }
}
Console.WriteLine($"Всего {count} чисел больше 0");