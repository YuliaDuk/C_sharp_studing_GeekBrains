// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.WriteLine("Введем массив размера m*m");
Console.WriteLine("Введите параметр m");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m,m];
int i=0;
int j=0;
int f=0;
for (int p = 1; p <=m*m; p++)
{
    matrix[i,j]=p;
    if(i==f && j<m-f-1) j++;
    else if(j==m-1-f && i<m-f-1) i++;
    else if(i==m-1-f && j>f) j--;
    else if(j==f && i>f) i--;
    if((i==f+1)&&(j==f)) f++;
}
for (int k = 0; k < m; k++)
{
    for (int l = 0; l < m; l++)
    {
        Console.Write(matrix[k,l] + " ");
    }
    Console.WriteLine();
}