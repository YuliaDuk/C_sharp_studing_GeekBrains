// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int sumdigit(int number)
{
    int sum = 0;
    if(number>=0)
    {
        for (int i = 0; number>0; i++)
        {
          sum = sum + number%10;
          number = number/10;  
        }
    }
    else
    {
        number = Math.Abs(number);
        for (int i = 0; number>=10; i++)
        {
            sum = sum + number%10;
            number = number/10;
        }
        sum = sum-number;
    }
    return sum;
}
Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр равна {sumdigit(N)}");