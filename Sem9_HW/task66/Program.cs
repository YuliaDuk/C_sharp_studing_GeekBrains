// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Sum(int A, int B)
{
    
    if (B==A) return A;
    else 
    {
        return B+Sum(A, B-1);
    }
}
Console.WriteLine("Введите значение M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение N");
int N = Convert.ToInt32(Console.ReadLine());
if(N>M)
{
    Console.WriteLine($"Сумма чисел в промежутке от М до N равна {Sum(M,N)}");
}
if(N<M)
{
    Console.WriteLine($"Сумма чисел в промежутке от М до N равна {Sum(N,M)}");
}
if(N==M)
{
    Console.WriteLine("M = N, в промежутке между ними нет чисел");
}