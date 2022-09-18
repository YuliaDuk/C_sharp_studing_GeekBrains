// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Необходимо задать две матрицы, при этом число столбцов первой матрицы должно равняться числу строк второй");
Console.WriteLine("Зададим первую матрицу m*n");
Console.WriteLine("Введите m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"У второй матрицы {n} строк. Введите число столбцов");
int p = Convert.ToInt32(Console.ReadLine());
int[,] matrix1 = new int[m,n];
int[,] matrix2 = new int[n,p];
Console.WriteLine("Первая матрица:");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix1[i,j] = new Random().Next(0, 4);
        Console.Write(matrix1[i,j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("Вторая матрица:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < p; j++)
    {
        matrix2[i,j] = new Random().Next(0, 6);
        Console.Write(matrix2[i,j] + " ");
    }
    Console.WriteLine();
}
int[,] matrixresult = new int[m,p];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < p; j++)
    {
        for (int k = 0; k < n; k++)
        {
            matrixresult[i,j] = matrixresult[i,j]+matrix1[i,k]*matrix2[k,j];
        }
    }
}
Console.WriteLine("Произведение матриц:");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < p; j++)
    {
        Console.Write(matrixresult[i,j] + " ");
    }
    Console.WriteLine();
}