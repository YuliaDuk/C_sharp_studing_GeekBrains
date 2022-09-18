// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите число N > 0");
int n=Convert.ToInt32(Console.ReadLine());
void Numbers(int N)
{
    if(N==0) return;
    else
    {
        Console.Write(N + " ");
        Numbers(N-1);
    }
}
if(n<=0)
{
    Console.WriteLine("Попробуй еще раз");
}
else if(n>0)
{
Numbers(n);
}