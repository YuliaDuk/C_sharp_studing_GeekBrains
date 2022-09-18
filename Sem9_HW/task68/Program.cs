// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 29

int Accerman(int a, int b)
{
  if(a==0) return b+1;
  else if(b==0 && a>0) 
  {
    return Accerman (a-1, 1);
  }
   else 
   {
    return Accerman(a-1, Accerman(a,b-1));
   }
}
Console.WriteLine("Введите m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите n");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Результат работы функции Аккерамана: {Accerman(m,n)}");