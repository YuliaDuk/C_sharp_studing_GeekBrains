// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int count = 2;
int count2 = 0;
if(N > 1)
{
    while(count<=N)
    {
        Console.WriteLine(count);
        count = count + 2;
    }
}
else
{
    while(count2>=N)
    {
    Console.WriteLine(count2);
    count2 = count2 - 2;
    }
}