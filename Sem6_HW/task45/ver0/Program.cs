// Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

Console.WriteLine("Введите длину массива");
int size = Convert.ToInt32(Console.ReadLine());
if(size<=0) Console.WriteLine("Введите число больше 0");
else
{
int[] array = new int[size];
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите {i} элемент массива");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Исходный массив" + '[' + string.Join("; ", array)+ ']');
int[] newarray = new int[size];
for (int j = 0; j < size; j++)
{
    newarray[j] = array[j];
}
Console.WriteLine("Новый массив" + '[' + string.Join("; ", newarray) + ']');
}