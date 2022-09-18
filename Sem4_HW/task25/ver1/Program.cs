// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int degree(int number, int n)
{
    int result = 1;
    for (int i = 0; i < n; i++)
    {
        result = result*number;
    }
    return result;
}
Console.WriteLine("Введите число А");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число В");
int B = Convert.ToInt32(Console.ReadLine());
if(B<=0)
{
    Console.WriteLine("Вы ввели не натуральное число В, попробуйте еще раз");
}
else
{
    Console.WriteLine($"Число {A} в степени {B} равно {degree(A, B)}");
}