// Задача 28*: Напишите программу, в которой задается массив чисел(ввод может быть с клавиатуры, либо можете сами задавать массив чисел) 
//и выдаёт произведение чисел от 1 до N, каждого элемента этого массива.
// {2, 3, 4} -> 2, 6, 24
// {5, 3, 6, 2, 5, 1} -> 6, 720, 2, 120, 1

Console.WriteLine("Введите длину массива");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];
for (int i = 0; i < length; i++)
{
    Console.WriteLine($"Введите {i} элемент массива");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
int composition (int[] arr, int j)
{
    int result = 1;
    if(array[j]>=1)
    {
        for (int q = 1; q <= array[j]; q++)
        {
            result = result*q;
        }
    }
    else
    {
       result = 0;
    }
    return result;
}
Console.WriteLine("Произведение чисел от 1 до i-го элемента массива");
for (int i = 0; i < length; i++)
{
    int A = composition(array, i);
    Console.Write($"{A}, ");
}