// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int [size];
Random rnd = new Random();
for (int i = 0; i < size; i++)
{
    array[i] = rnd.Next(0, 1000);
}
Console.WriteLine("Исходный массив: " + '[' + string.Join(", ", array) + ']');
int count = 0;
for (int i = 0; i < size; i++)
{
    if(array[i]>=10 && array[i]<=99)
    {
        count++;
    }
}
Console.WriteLine($"Всего {count} элементов массива лежат в отрезке [10, 99]");