// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
int A = Convert.ToInt32(Console.ReadLine());
int B = Math.Abs(A);
if(B<100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    while(B>999)
    {
        B = B/10;
    }
    Console.WriteLine($"Третья цифра числа {B%10}");
   
}