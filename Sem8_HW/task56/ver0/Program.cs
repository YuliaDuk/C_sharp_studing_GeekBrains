// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Задаем двумерный прямоугольный массив размером m*n");
Console.WriteLine("Введите размер m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер n");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int [m,n];
if(n==m)
{
    Console.WriteLine("Попробуй еще раз");
}
else
{
{
    Console.WriteLine("Исходный массив");
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i,j] = new Random().Next(0,5);
            Console.Write(matrix[i,j] + " ");
        }
       Console.WriteLine(); 
    }
}
int[] array = new int[m];
for (int i = 0; i < m; i++)
{
    int sum = 0;
    for (int j = 0; j < n; j++)
    {
        sum=sum+matrix[i,j];
    }
    array[i]=sum;
}
Console.WriteLine();
Console.WriteLine($"Сумма элементов в каждом из {m} столбцов равна:" + string.Join("; ", array));
int min = array[0];
for (int i = 0; i < m; i++)
{
    if(array[i]<min) 
    {
        min=array[i];
    }
}
for (int i = 0; i < m; i++)
{
    if(array[i]==min) 
    {
       Console.WriteLine($"Номер строки с наименьшей суммой элементов: {i+1}");
    }
}
}