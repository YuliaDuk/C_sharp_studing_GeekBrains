// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int palindrom(int number)
{
    int digitcount = (int)Math.Log10(number)+1;
    int count = 0;
    int newnumber = 0;
    while(count<digitcount)
    {
        int lastdig = number%10;
        newnumber = lastdig*(int)Math.Pow(10, (digitcount-count-1))+newnumber;
        number = (number - lastdig)/10;
        count++;
    }
    return newnumber;
}
Console.WriteLine("Введите пятизначное число");
int N = Convert.ToInt32(Console.ReadLine());
int B = palindrom(N);
if(N==B && Math.Abs(N)<100000 && Math.Abs(N)>9999)
{
    Console.WriteLine("Является палиндромом");
}
else if(N!=B && Math.Abs(N)<100000 && Math.Abs(N)>9999)
{
    Console.WriteLine("Не является палиндромом");
}
else
{
    Console.WriteLine("Введите другое число");
}
