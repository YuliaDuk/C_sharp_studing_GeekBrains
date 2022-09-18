//Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника

Console.WriteLine("введите число N > 0");
int n = Convert.ToInt32(Console.ReadLine());
if(n<=0) Console.WriteLine("Введите другое число");
int[,]matrix = new int[n,n*2-1];
matrix[0,n-1]=1;
for (int i = 1; i <n; i++)
{
    for (int j = n-1-i; j < n+1+i; j+=2)
    {
        if(j==0)
        {
            matrix[i,j]=matrix[i-1,j]+matrix[i-1,j+1];
        }
        else if(j==n*2-2)
        {
            matrix[i,j]=matrix[i-1,j-1]+matrix[i-1,j];
        }
        else 
        {
            matrix[i,j]=matrix[i-1,j-1]+ matrix[i-1,j+1];
        }
    }
}
Console.WriteLine($"Треугольник Паскаля для {n} строк:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n*2-1; j++)
    {
        string symbol= matrix[i,j].ToString();
        if(symbol.Length==1)
        {
            symbol=symbol.Replace('0', ' ');
        }
        Console.Write(symbol);
    }
    Console.WriteLine();
}