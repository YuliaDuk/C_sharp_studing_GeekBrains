// Задача 38: Задайте с клавиатуры массив вещественных (double) чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.WriteLine("Введите размер массива");
int length = Convert.ToInt32(Console.ReadLine());
double[] array = new double[length];
for (int i = 0; i < length; i++)
{
    Console.WriteLine($"Введите {i} элемент массива");
    array[i] = Convert.ToDouble(Console.ReadLine());
}
Console.WriteLine("Массив: " + '['+ string.Join("; ", array)+']');
double max = array[0];
double min = array[0];
for (int i = 0; i < length; i++)
{
    if(array[i]>max) max = array[i];
    if(array[i]<min) min = array[i];
}
Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна {max-min}");