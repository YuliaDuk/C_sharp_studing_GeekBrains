// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введите длину массива");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int [length];
for (int i = 0; i < length; i++)
{
    Console.WriteLine($"Введите {i} элемент массива");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Массив: {0}",'[' + String.Join(", ",array)+']');