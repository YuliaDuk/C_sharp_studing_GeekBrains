// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число");
string? number = Console.ReadLine();
int length = number.Length;
int[] array = new int [length];
int sum = 0;
if(number.Contains('-'))
{
    for (int i = 2; i < length; i++)
    {
        array[i] = Convert.ToInt32(number[i].ToString());
        sum = sum + array[i];
    }
    array[1] = Convert.ToInt32(number[1].ToString());
    sum = sum - array[1];
}
else
{
    for (int i = 0; i < length; i++)
    {
        array[i] = Convert.ToInt32(number[i].ToString());
        sum = sum + array[i];
    }
}
Console.WriteLine($"Сумма цифр заданного числа равна {sum}");