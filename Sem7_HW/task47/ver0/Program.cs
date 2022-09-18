// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("Задаем массив размером m*n");
Console.WriteLine("Введите m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine());
double[,] matrix = new double [m, n];
Console.WriteLine("Введите минимальное значение для случайного числа в матрице");
int minvalue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение для случайного числа в матрице");
int maxvalue = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Random rnd = new Random();
        matrix[i, j] = Math.Round((rnd.NextDouble() * (maxvalue - minvalue) + minvalue), 2);
        Console.Write(matrix[i,j] + "; ");
    }
    Console.WriteLine();
}