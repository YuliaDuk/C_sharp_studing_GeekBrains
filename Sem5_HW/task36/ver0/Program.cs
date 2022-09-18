// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int[] FillArray(int size, int lr, int rr)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(lr, rr+1);
    }
    return array;
}
Console.WriteLine("Введите размер массива");
int length = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[length];
arr = FillArray(length, 0, 11);
Console.WriteLine("Исходный массив: "+'['+string.Join(", ", arr)+']');
int sum = 0;
for (int i = 1; i < length; i=i+2)
{
    sum = sum+arr[i];
}
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях равна {sum}");


