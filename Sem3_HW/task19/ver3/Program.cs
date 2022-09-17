// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");
string number = Console.ReadLine();
int length = number.Length;
char[] arr = number.ToCharArray();
for (int i = 0; i < length/2; i++)
{
    char temp = arr[i];
    arr[i] = arr[length-1-i];
    arr[length-1-i] = temp;
}
if(number.Contains('-')&& length==6)
{
    Console.WriteLine("Число не является палиндромом");
}
else if(number.Contains('-')&& length!=6)
{
    Console.WriteLine("Введено не пятизначное число");
}
else if(number.SequenceEqual(arr)&&length==5)
{
    Console.WriteLine("Число является палиндромом");
}
else if(number.SequenceEqual(arr)&&length!=5)
{
    Console.WriteLine("Введено не пятизначное число, но оно является палиндромом");
}
else 
{
    Console.WriteLine("Введено не пятизначное число");
}
