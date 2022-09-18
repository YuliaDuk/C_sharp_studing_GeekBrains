// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void FillArray(int[,,] matrix)
{
    int count = 10;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i,j,k] = count+1;
                count++;
            }
        }
    }
}
void MixMatrix(int[,,] matrix) //меняем местами 2 случайно выбранных элемента
{
    for (int q = 0; q < matrix.GetLength(0)*matrix.GetLength(1)*matrix.GetLength(2); q++)
    {  
    int number1 = new Random().Next(11, 11+matrix.GetLength(0)*matrix.GetLength(1)*matrix.GetLength(2));
    int number2 = new Random().Next(11, 11+matrix.GetLength(0)*matrix.GetLength(1)*matrix.GetLength(2));
    for (int i = 0; i < matrix.GetLength(0); i++)
    {  
        for (int j = 0; j <  matrix.GetLength(1); j++)
        {
            for (int k = 0; k <matrix.GetLength(2); k++)
            {
            if(matrix[i,j,k]==number1)
            {
                matrix[i,j,k]=1;
            }
            if(matrix[i,j,k]==number2)
            {
                matrix[i,j,k]=2;
            }
            }
        }
    }  
    for (int i = 0; i < matrix.GetLength(0); i++)
    {  
        for (int j = 0; j <  matrix.GetLength(1); j++)
        {
            for (int k = 0; k <matrix.GetLength(2); k++)
            {
            if(matrix[i,j,k]==1)
            {
                matrix[i,j,k]=number2;
            }
            if(matrix[i,j,k]==2)
            {
                matrix[i,j,k]=number1;
            }
            }
        }
    }  
    }
}
void PrintArray(int[,,] matrix)
{
     for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write(matrix[i, j, k]);
                Console.Write($" ({i}, {j}, {k}) ");
               
            }
            Console.WriteLine();
        }
    }
}
Console.WriteLine("Задаем размер массива a*b*c");
Console.WriteLine("Введите a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите c");
int c = Convert.ToInt32(Console.ReadLine());
int [,,] matrix = new int[a,b,c];
FillArray(matrix);
MixMatrix(matrix);
PrintArray(matrix);