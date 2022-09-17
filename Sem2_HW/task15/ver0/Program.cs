// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру, обозначающую день недели");
int N = Convert.ToInt32(Console.ReadLine());
switch(N)
{
    case 1:
    Console.WriteLine("будний день");
    break;
    case 2:
    Console.WriteLine("будний день");
    break;
    case 3:
    Console.WriteLine("будний день");
    break;
    case 4:
    Console.WriteLine("будний день");
    break;
    case 5:
    Console.WriteLine("будний день");
    break;
    case 6:
    Console.WriteLine("выходной день");
    break;
    case 7:
    Console.WriteLine("выходной день");
    break;
    default:
    Console.WriteLine("Введите цифру от 1 до 7");
    break;
}