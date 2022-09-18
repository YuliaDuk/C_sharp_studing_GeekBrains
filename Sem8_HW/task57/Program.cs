// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3
// 4, 6, 1
// 2, 1, 6

// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

Console.WriteLine("Зададим массив размером m*n");
Console.WriteLine("Введите m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m,n];
Console.WriteLine("Исходный массив");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i,j]= new Random().Next(0,10);
        Console.Write(matrix[i,j]+ " ");
    }
    Console.WriteLine();
}
for (int number = 0; number < 10; number++)
{
    int sum=0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
        if(matrix[i,j]==number)
        {
            sum++;
        }
        }
    }
    if(sum!=0) Console.WriteLine($"Число {number} встречается {sum} раз");
}