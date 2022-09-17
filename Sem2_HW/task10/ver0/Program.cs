// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());
int digit2 = (number/10)%10;
if(number>99 && number<1000)
{
    Console.WriteLine($"Вторая цифра числа {digit2}");
}
if(number<-99 && number>-1000)
{
    Console.WriteLine($"Вторая цифра числа {digit2*(-1)}");
}
if(number<-999 || number>999 || Math.Abs(number)<=99)
{
    Console.WriteLine("введите другое число");
}