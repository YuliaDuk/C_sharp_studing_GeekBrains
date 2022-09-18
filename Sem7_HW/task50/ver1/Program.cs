// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// > такого числа в массиве нет

Console.WriteLine("Создаем массив размера m*n");
Console.WriteLine("Введите m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m,n];
Console.WriteLine("Введите минимально значение для чисел в массиве");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимально значение для чисел в массиве");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Массив:");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i,j]=new Random().Next(min, max+1);
        Console.Write(matrix[i,j]+ " ");
    }
    Console.WriteLine();
}
Console.Write("Давайте проверим, есть ли введенное число в массиве. Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum=0;
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        
        if(matrix[i,j]==number) 
        {
        Console.WriteLine($"Такое число есть на позиции {i} {j}");
        sum = sum+1;
        }
    }   
}
if(sum == 0) Console.WriteLine("Такого числа нет");