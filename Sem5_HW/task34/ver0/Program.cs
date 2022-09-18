// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

void FillArray(int[] array, int leftrange, int rigthtrange)
{
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(leftrange, rigthtrange+1);
}
}
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[size];
FillArray(arr, 100, 999);
Console.WriteLine('['+ string.Join(", ", arr) + ']');
int count = 0;
for (int i = 0; i < size; i++)
{
    if(arr[i]%2==0)
    {
        count++;
    }
}
Console.WriteLine($"В массиве {count} четных чисел");
