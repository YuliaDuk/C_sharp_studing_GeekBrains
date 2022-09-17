// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

string newnumber(string number)
{
    int length = number.Length;
    string result = String.Empty;
    for (int i = 0; i < length; i++)
    {
        result = result + $"{number[length-i-1]}";
    }
    return result;
}
Console.WriteLine("Введите пятизначное число");
string N = Console.ReadLine();
string palindrom = newnumber(N);
if(N.Contains('-') && N.Length==6)
{
    Console.WriteLine("Не является палиндромом");
}
else if(N.Contains('-')&& N.Length!=6)
{
    Console.WriteLine("Введено не пятизначное число");
}
else if(N.Length==5 && palindrom==N)
{
    Console.WriteLine("Число является палиндромом");
}
else if(N.Length!=5)
{
    Console.WriteLine("Введите другое число");
}
else if(N.Length==5 && palindrom!=N)
{
    Console.WriteLine("Число не является палиндромом");
}