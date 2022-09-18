// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Уравнение прямой y = kx + b");
Console.WriteLine("Для двух прямых необходимо ввести k и b");
Console.WriteLine("Введите k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2");
double b2 = Convert.ToDouble(Console.ReadLine());
double[] Point(double k1, double b1, double k2, double b2)
{
    double[] array = new double[2];
    array[0]=(b2-b1)/(k1-k2);
    array[1] = (k1*(b2-b1)/(k1-k2))+b1;
    return array;
}
if(k1==k2 && b1!=b2) Console.WriteLine("Прямые параллельны, точек пересечения нет");
if(k1==k2 && b1==b2) Console.WriteLine("Прямые совпадают");
else if(k1!=k2)
{
double[] arr = new double[2];
arr = Point(k1, b1, k2, b2);
Console.WriteLine($"Точка пересечения прямых"+ '('+string.Join(";", arr)+')');
}