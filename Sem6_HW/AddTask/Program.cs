// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N. (использовать рекурсию)
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
if(N<=0) Console.WriteLine("Введите число больше 0");
else
{
    int Multiplication(int number)
    {
        if(number==1) return 1;
        else
        {
            return number* Multiplication(number-1);
        }
    }
    Console.WriteLine($"Произведение чисел от 1 до {N} равно {Multiplication(N)}");
}