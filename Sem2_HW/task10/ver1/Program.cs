// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число");
string number = Console.ReadLine()!;
int seconddigit = int.Parse(number[1].ToString());
int seconddigitforneg = int.Parse(number[2].ToString());
int length = number.Length;
if(number.Contains('-'))
{
    Console.WriteLine($"Вторая цифра числа {seconddigitforneg}");
}
else 
{
    Console.WriteLine($"Вторая цифра числа {seconddigit}");
}
if(length != 3)
{
    Console.WriteLine("Вы ввели не трехзначное или отрицательное число, попробуйте еще раз");
}