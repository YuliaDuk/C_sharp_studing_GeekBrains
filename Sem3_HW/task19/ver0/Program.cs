// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
if(number < 10000 || number>99999)
{
    Console.WriteLine("Число введено неверно");
}
else
{
    int first = number/10000;
    int second = number/1000%10;
    int fourth = number/10%10;
    int fifth = number%10;
    if(first == fifth && second ==fourth)
    {
        Console.WriteLine("Число является палиндромом");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом");
    }

}