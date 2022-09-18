// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Задаем массив размером m*n");
Console.WriteLine("Введите m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
 for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().Next(1, 10);
        Console.Write(matrix[i,j]+ " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.Write("Среднее арифметического каждого столбца: ");
for (int i = 0; i < n; i++)
{
    double number = 0;
    for (int j = 0; j < m; j++)
    {
        number =(number + matrix[j, i]);
    }
    Console.Write(number/m + "; ");
}