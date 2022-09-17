// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int SecondDigit(int number)
{
    number = Math.Abs(number);
        while(number >100)
    {
        number = number/10;
    }
    int digit = number%10;
    return digit;
}
//функция для поиска второй цифры любого числа, в котором больше одной цифры. не понимаю, как отсечь числа меньше 10
Console.WriteLine("Введите трехзначное число");
int N = Convert.ToInt32(Console.ReadLine());
if(Math.Abs(N)>99 && Math.Abs(N)<1000)
{
    int digit2 = SecondDigit(N);
Console.WriteLine($"Вторая цифра числа {digit2}");
}
else
{
  Console.WriteLine("Введите другое число");
}